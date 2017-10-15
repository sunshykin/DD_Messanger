using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatterBox.Extentions;
using ChatterBox.Model;

namespace ChatterBox.DataLayer.RawSQL
{
    public class ChatsRepository : IChatsRepository
    {

        private readonly string _connectionString;
        private readonly IUsersRepository _usersRepository;
        private readonly IAttachsRepository _attachsRepository;
        private readonly IMessagesRepository _messagesRepository;

        public ChatsRepository(string connectionString, IUsersRepository usersRepository = null,
            IAttachsRepository attachsRepository = null, IMessagesRepository messagesRepository = null)
        {
            _connectionString = connectionString;
            _usersRepository = usersRepository ?? new UsersRepository(_connectionString, null, this);
            _attachsRepository = attachsRepository ?? new AttachsRepository(_connectionString, _usersRepository);
            _messagesRepository = messagesRepository ?? new MessagesRepository(_connectionString, _usersRepository, _attachsRepository, this);
        }

        public Chat Create(string title, IEnumerable<Guid> members, string picture = null)
        {
            if (title.IsEmpty())
                throw new ArgumentException("Название чата не задано");
            if (!members.Any())
                throw new ArgumentException("Не выбраны пользователи");
            Chat chat = new Chat()
            {
                Id = Guid.NewGuid(),
                Title = title,
                Picture = picture
            };

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.Transaction = transaction;
                        command.CommandText = "INSERT INTO Chats (ChatId, Title, PicturePath) VALUES (@id, @title, @pic)";

                        command.Parameters.AddWithValue("@id", chat.Id);
                        command.Parameters.AddWithValue("@title", chat.Title);
                        command.Parameters.AddWithValue("@pic", chat.Picture ?? String.Empty);

                        command.ExecuteNonQuery();
                    }
                    foreach (var m in members)
                    {
                        using (var command = connection.CreateCommand())
                        {
                            command.Transaction = transaction;
                            command.CommandText = "INSERT INTO ChatUsers (ChatId, UserId) " +
                                                  "VALUES (@chatid, @userid)";
                            command.Parameters.AddWithValue("@chatid", chat.Id);
                            command.Parameters.AddWithValue("@userid", m);
                            command.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                    chat.Members = GetChatUsers(chat.Id);
                    chat.Messages = GetChatMessages(chat.Id);
                    chat.Attachs = GetChatAttachs(chat.Id);
                    return chat;
                }
            }
        }

        public void Delete(Guid id)
        {
            if (!ChatExists(id))
                throw new ArgumentException("Не удалось найти данный чат");
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.Transaction = transaction;
                        command.CommandText = "DELETE FROM ChatUsers WHERE ChatId = @id";
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                    using (var command = connection.CreateCommand())
                    {
                        command.Transaction = transaction;
                        command.CommandText = "DELETE FROM Chats WHERE ChatId = @id";
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
            }
        }

        public Chat Get(Guid id)
        {
            if (!ChatExists(id))
                throw new ArgumentException("Не удалось найти данный чат");
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT TOP(1) * FROM Chats WHERE ChatId = @id";
                    command.Parameters.AddWithValue("@id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        reader.Read();
                        return new Chat()
                        {
                            Id = reader.GetGuid(reader.GetOrdinal("ChatId")),
                            Title = reader.GetString(reader.GetOrdinal("Title")),
                            Picture = reader.GetString(reader.GetOrdinal("PicturePath")),
                            Members = GetChatUsers(reader.GetGuid(reader.GetOrdinal("ChatId"))),
                            Messages = GetChatMessages(reader.GetGuid(reader.GetOrdinal("ChatId"))),
                            Attachs = GetChatAttachs(reader.GetGuid(reader.GetOrdinal("ChatId")))
                        };
                    }
                }
            }
        }

        public bool ChatExists(Guid id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT TOP(1) ChatId FROM Chats WHERE ChatId = @id";
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

        public IEnumerable<User> GetChatUsers(Guid id)
        {
            if (!ChatExists(id))
                throw new ArgumentException("Не удалось найти данный чат");
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM ChatUsers WHERE ChatId = @id";
                    command.Parameters.AddWithValue("@id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return _usersRepository.Get(reader.GetGuid(reader.GetOrdinal("UserId")));
                        }
                    }
                }
            }
        }

        public IEnumerable<Attach> GetChatAttachs(Guid id)
        {
            if (!ChatExists(id))
                throw new ArgumentException("Не удалось найти данный чат");
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Attachs a INNER JOIN Messages m ON " +
                                          "a.MessageId = m.MessageId WHERE m.ChatId = @id";
                    command.Parameters.AddWithValue("@id", id);
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

        public IEnumerable<Message> GetChatMessages(Guid id)
        {
            if (!ChatExists(id))
                throw new ArgumentException("Не удалось найти данный чат");
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Messages WHERE ChatId = @id";
                    command.Parameters.AddWithValue("@id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return _messagesRepository.Get(reader.GetGuid(reader.GetOrdinal("MessageId")));
                        }
                    }
                }
            }
        }

        public void ChangeTitle(Guid id, string newTitle)
        {
            if (!ChatExists(id))
                throw new ArgumentException("Не удалось найти данный чат");
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE Chats SET Title = @title WHERE ChatId = @id";
                    command.Parameters.AddWithValue("@title", newTitle);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void ChangePicture(Guid id, string newPath)
        {
            if (!ChatExists(id))
                throw new ArgumentException("Не удалось найти данный чат");
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE Chats SET PicturePath = @pic WHERE ChatId = @id";
                    command.Parameters.AddWithValue("@pic", newPath);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddMembers(Guid id, IEnumerable<Guid> members)
        {
            if (!ChatExists(id))
                throw new ArgumentException("Не удалось найти данный чат");
            if (!members.Any())
                throw new ArgumentException("Не выбраны пользователи");
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                foreach (var m in members)
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "INSERT INTO ChatUsers (ChatId, UserId) " +
                                              "VALUES (@chatid, @userid)";
                        command.Parameters.AddWithValue("@chatid", id);
                        command.Parameters.AddWithValue("@userid", m);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public void DeleteMembers(Guid id, IEnumerable<Guid> members)
        {
            if (!ChatExists(id))
                throw new ArgumentException("Не удалось найти данный чат");
            if (!members.Any())
                throw new ArgumentException("Не выбраны пользователи");
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                foreach (var m in members)
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "DELETE FROM ChatUsers " +
                                              "WHERE ChatId = @chatid AND UserId = @userid";
                        command.Parameters.AddWithValue("@chatid", id);
                        command.Parameters.AddWithValue("@userid", m);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
