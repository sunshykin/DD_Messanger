using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ChatterBox.Extentions;
using ChatterBox.Model;

namespace ChatterBox.DataLayer.RawSQL
{
    public class UsersRepository : IUsersRepository
    {
        private readonly string _connectionString;
        private readonly IAuthRepository _authRepository;
        private readonly IChatsRepository _chatReposirory;

        public UsersRepository(string connectionString, IAuthRepository authRepository = null, 
            IChatsRepository chatReposirory = null)
        {
            _connectionString = connectionString;
            _authRepository = authRepository ?? new AuthRepository(_connectionString, this);
            _chatReposirory = chatReposirory ?? new ChatsRepository(_connectionString, this);
        }

        public User Create(User user, string login, string pass)
        {
            if (user.Name.IsEmpty())
            {
                var resp = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Имя пользователя не задано"),
                    ReasonPhrase = "Wrong User Arguments"
                };
                throw new HttpResponseException(resp);
            }
            if (login.IsEmpty() || pass.IsEmpty())
            {
                var resp = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Поля логин и/или пароль не заполнены"),
                    ReasonPhrase = "Wrong User Arguments"
                };
                throw new HttpResponseException(resp);
            }
            if (_authRepository.LoginExists(login))
            {
                var resp = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Выбранный Вами логин занят, придумайте другой"),
                    ReasonPhrase = "Wrong User Arguments"
                };
                throw new HttpResponseException(resp);
            }
            User result = new User()
            {
                Id = Guid.NewGuid(),
                Name = user.Name,
                Picture = user.Picture
            };
            
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.Transaction = transaction;
                        command.CommandText = "INSERT INTO Users (UserId, Name, PicturePath) VALUES (@id, @name, @pic)";

                        command.Parameters.AddWithValue("@id", result.Id);
                        command.Parameters.AddWithValue("@name", result.Name);
                        command.Parameters.AddWithValue("@pic", result.Picture ?? "");

                        command.ExecuteNonQuery();
                    }
                    using (var command = connection.CreateCommand())
                    {
                        command.Transaction = transaction;
                        command.CommandText = "INSERT INTO Auth (Login, PasswordHash, UserId) VALUES (@login, @pass, @userid)";

                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@pass", AuthRepository.GetHashString(pass));
                        command.Parameters.AddWithValue("@userid", result.Id);

                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    result.LogInfo = _authRepository.Get(result.Id);
                    return result;
                }
            }
        }

        public void Delete(Guid id)
        {
            if (!UserExists(id))
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent($"Пользователь с ID = {id} не найден"),
                    ReasonPhrase = "User ID Not Found"
                };
                throw new HttpResponseException(resp);
            }
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.Transaction = transaction;
                        command.CommandText = "DELETE FROM Auth WHERE UserId = @id";
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                    using (var command = connection.CreateCommand())
                    {
                        command.Transaction = transaction;
                        command.CommandText = "DELETE FROM Users WHERE UserId = @id";
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
            }
        }

        public User Get(Guid id)
        {
            if (!UserExists(id))
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent($"Пользователь с ID = {id} не найден"),
                    ReasonPhrase = "User ID Not Found"
                };
                throw new HttpResponseException(resp);
            }
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT TOP(1) Name, PicturePath FROM Users WHERE UserId = @id";
                    command.Parameters.AddWithValue("@id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        reader.Read();
                        return new User
                        {
                            Id = id,
                            Name = reader.GetString(reader.GetOrdinal("Name")),
                            Picture = reader.GetString(reader.GetOrdinal("PicturePath")),
                            LogInfo = _authRepository.Get(id)
                        };
                    }
                }
            }
        }

        public bool UserExists(Guid id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT TOP(1) UserId FROM Users WHERE UserId = @id";
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

        public void ChangeLogin(Guid userid, string newLogin, string pass)
        {
            if (!UserExists(userid))
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent($"Пользователь с ID = {userid} не найден"),
                    ReasonPhrase = "User ID Not Found"
                };
                throw new HttpResponseException(resp);
            }
            Auth auth = _authRepository.Get(userid);
            if (auth.Password != AuthRepository.GetHashString(pass))
            {
                var resp = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Неверный пароль"),
                    ReasonPhrase = "Wrong User Arguments"
                };
                throw new HttpResponseException(resp);
            }
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE Auth SET Login = @login WHERE UserId = @userid";
                    command.Parameters.AddWithValue("@login", newLogin);
                    command.Parameters.AddWithValue("@userid", userid);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void ChangePassword(Guid userid, string oldPassword, string newPassword)
        {
            if (!UserExists(userid))
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent($"Пользователь с ID = {userid} не найден"),
                    ReasonPhrase = "User ID Not Found"
                };
                throw new HttpResponseException(resp);
            }
            Auth auth = _authRepository.Get(userid);
            if (auth.Password != AuthRepository.GetHashString(oldPassword))
            {
                var resp = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Неверный пароль"),
                    ReasonPhrase = "Wrong User Arguments"
                };
                throw new HttpResponseException(resp);
            }
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE Auth SET PasswordHash = @pass WHERE UserId = @userid";
                    command.Parameters.AddWithValue("@pass", AuthRepository.GetHashString(newPassword));
                    command.Parameters.AddWithValue("@userid", userid);
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<Chat> GetUserChats(Guid userid)
        {
            if (!UserExists(userid))
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent($"Пользователь с ID = {userid} не найден"),
                    ReasonPhrase = "User ID Not Found"
                };
                throw new HttpResponseException(resp);
            }
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM ChatUsers WHERE UserId = @id";
                    command.Parameters.AddWithValue("@id", userid);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return _chatReposirory.Get(reader.GetGuid(reader.GetOrdinal("ChatId")));
                        }
                    }
                }
            }
        }

        public User SignIn(string login, string pass)
        {
            return _authRepository.SignIn(login, pass);
        }
    }
}
