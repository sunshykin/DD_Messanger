﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using ChatterBox.Extentions;
using ChatterBox.Model;

namespace ChatterBox.DataLayer.RawSQL
{
    public class MessagesRepository : IMessagesRepository
    {
        private readonly string _connectionString;
        private readonly IUsersRepository _usersRepository;
        private readonly IAttachsRepository _attachsRepository;
        private readonly IChatsRepository _chatsRepository;

        public MessagesRepository(string connectionString, IUsersRepository usersRepository = null,
            IAttachsRepository attachsRepository = null, IChatsRepository chatsRepository = null)
        {
            _connectionString = connectionString;
            _usersRepository = usersRepository ?? new UsersRepository(_connectionString);
            _attachsRepository = attachsRepository ?? new AttachsRepository(_connectionString, _usersRepository);
            _chatsRepository = chatsRepository ?? new ChatsRepository(_connectionString, _usersRepository, _attachsRepository, this);
        }


        public Message Send(string text, Guid userid, Guid chatid, IEnumerable<string> files = null,
            bool selfDestruction = false, string destructionTime = null)
        {
            if (text.IsEmpty())
                throw new ArgumentException("Введите текст сообщения");
            if (userid == null)
                throw new ArgumentException("Неверный id пользователя");
            if (chatid == null)
                throw new ArgumentException("Неверный id чата");
            files = files ?? new List<string>();
            var msg = new Message() {Text = text};
            msg.Id = Guid.NewGuid();
            msg.Date = DateTime.Now;
            msg.SelfDestruction = selfDestruction;
            msg.SelfDestructionDate = destructionTime == null ? DateTime.MaxValue : Convert.ToDateTime(destructionTime);

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.Transaction = transaction;
                        command.CommandText = "INSERT INTO Messages (MessageId, Text, Date, " +
                                              "SelfDestruction, SelfDestructionDate, SenderId, ChatId) " +
                                              "VALUES (@msg, @text, @date, @sd, @sddate, @sender, @chat)";

                        command.Parameters.AddWithValue("@msg", msg.Id);
                        command.Parameters.AddWithValue("@text", msg.Text);
                        command.Parameters.AddWithValue("@date", msg.Date);
                        command.Parameters.AddWithValue("@sd", msg.SelfDestruction);
                        command.Parameters.AddWithValue("@sddate", msg.SelfDestructionDate);
                        command.Parameters.AddWithValue("@sender", userid);
                        command.Parameters.AddWithValue("@chat", chatid);

                        command.ExecuteNonQuery();
                    }
                    foreach (var f in files)
                    {
                        using (var command = connection.CreateCommand())
                        {
                            command.Transaction = transaction;
                            command.CommandText = "INSERT INTO Attachs (AttachId, Path, UserId, MessageId)" +
                                                  " VALUES (@attachid, @path, @userid, @messageid)";

                            command.Parameters.AddWithValue("@attachid", Guid.NewGuid());
                            command.Parameters.AddWithValue("@path", f);
                            command.Parameters.AddWithValue("@userid", userid);
                            command.Parameters.AddWithValue("@messageid", msg.Id);

                            command.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                    msg.Sender = _usersRepository.Get(userid);
                    msg.Attachs = GetMessageAttachs(msg.Id);
                    msg.Chat = _chatsRepository.Get(chatid);
                    return msg;
                }
            }
        }

        public void Delete(Guid id)
        {
            if (!MessageExists(id))
                throw new ArgumentException("Не удалось найти данное сообщение");
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.Transaction = transaction;
                        command.CommandText = "DELETE FROM Attachs WHERE MessageId = @id";
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                    using (var command = connection.CreateCommand())
                    {
                        command.Transaction = transaction;
                        command.CommandText = "DELETE FROM Messages WHERE MessageId = @id";
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
            }
        }

        public Message Get(Guid id)
        {
            if (!MessageExists(id))
                throw new ArgumentException("Не удалось найти данное сообщение");
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT TOP(1) * FROM Messages WHERE MessageId = @id";
                    command.Parameters.AddWithValue("@id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        reader.Read();
                        return new Message()
                        {
                            Id = reader.GetGuid(reader.GetOrdinal("MessageId")),
                            Text = reader.GetString(reader.GetOrdinal("Text")),
                            Date = reader.GetDateTime(reader.GetOrdinal("Date")),
                            SelfDestruction = reader.GetBoolean(reader.GetOrdinal("SelfDestruction")),
                            SelfDestructionDate = reader.GetDateTime(reader.GetOrdinal("SelfDestructionDate")),
                            Attachs = GetMessageAttachs(reader.GetGuid(reader.GetOrdinal("MessageId"))),
                            Sender = _usersRepository.Get(reader.GetGuid(reader.GetOrdinal("SenderId"))),
                            Chat = _chatsRepository.Get(reader.GetGuid(reader.GetOrdinal("ChatId")))
                        };
                    }
                }
            }
        }

        public bool MessageExists(Guid id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT TOP(1) MessageId FROM Messages WHERE MessageId = @id";
                    command.Parameters.AddWithValue("@id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                            return false;
                        return true;
                    }
                }
            }
        }
        

        public IEnumerable<Attach> GetMessageAttachs(Guid messageid)
        {
            if (!MessageExists(messageid))
                throw new ArgumentException("Не удалось найти данное сообщение");
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT AttachId FROM Attachs WHERE MessageId = @id";
                    command.Parameters.AddWithValue("@id", messageid);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return _attachsRepository.Get(reader.GetGuid(reader.GetOrdinal("AttachId")));
                        }
                    }
                }
            }
        }

        public IEnumerable<Message> GetMessagesFromUser(Guid userid)
        {
            if (!_usersRepository.UserExists(userid))
                throw new ArgumentException("Не удалось найти данного пользователя");
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT MessageId FROM Messages WHERE SenderId = @id";
                    command.Parameters.AddWithValue("@id", userid);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return Get(reader.GetGuid(reader.GetOrdinal("MessageId")));
                        }
                    }
                }
            }
        }

        public IEnumerable<Message> GetMessagesToUser(Guid userid)
        {
            if (!_usersRepository.UserExists(userid))
                throw new ArgumentException("Не удалось найти данного пользователя");
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Messages m INNER JOIN ChatUsers c ON " +
                                          "c.ChatId = m.ChatId WHERE c.UserId = @id AND m.SenderId != @id";
                    command.Parameters.AddWithValue("@id", userid);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return Get(reader.GetGuid(reader.GetOrdinal("MessageId")));
                        }
                    }
                }
            }
        }

        public IEnumerable<Message> SearchMessages(Guid userid, string keyword)
        {
            if (!_usersRepository.UserExists(userid))
                throw new ArgumentException("Не удалось найти данного пользователя");
            return GetMessagesFromUser(userid).Union(GetMessagesToUser(userid))
                .Where(m => m.Text.Contains(keyword));
        }
    }
}