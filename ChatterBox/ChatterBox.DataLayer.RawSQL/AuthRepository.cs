using System;
using System.Text;
using ChatterBox.Model;
using System.Data.SqlClient;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Web.Http;
using ChatterBox.Extentions;

namespace ChatterBox.DataLayer.RawSQL
{
    public class AuthRepository : IAuthRepository
    {
        private readonly string _connectionString;
        private readonly IUsersRepository _usersRepository;

        public static string GetHashString(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
                sb.Append(hash[i].ToString("X2"));
            return sb.ToString();
        }

        public AuthRepository(string connectionString, IUsersRepository usersRepository = null)
        {
            _connectionString = connectionString;
            _usersRepository = usersRepository ?? new UsersRepository(_connectionString, this);
        }

        public Auth Get(Guid userid)
        {
            if (userid == null || !_usersRepository.UserExists(userid))
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
                    command.CommandText = "SELECT TOP(1) Login, PasswordHash, UserId FROM Auth WHERE UserId = @id";
                    command.Parameters.AddWithValue("@id", userid);
                    using (var reader = command.ExecuteReader())
                    {
                        reader.Read();
                        return new Auth
                        {
                            Login = reader.GetString(reader.GetOrdinal("Login")),
                            Password = reader.GetString(reader.GetOrdinal("PasswordHash"))
                        };
                    }
                }
            }
        }

        public bool LoginExists(string login)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT TOP(1) Login FROM Auth WHERE Login = @login";
                    command.Parameters.AddWithValue("@login", login);
                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                            return false;
                        return true;
                    }
                }
            }
        }

        public bool CanSignIn(string login, string pass)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT TOP(1) Login, PasswordHash FROM Auth " +
                                          "WHERE Login = @login AND PasswordHash = @pass";
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@pass", GetHashString(pass));
                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                            return false;
                        return true;
                    }
                }
            }
        }

        public User SignIn(string login, string pass)
        {
            if (!CanSignIn(login, pass))
            {
                var resp = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Пользователь с таким логином/паролем не найден"),
                    ReasonPhrase = "Wrong Auth Arguments"
                };
                throw new HttpResponseException(resp);
            }
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT TOP(1) UserId FROM Auth " +
                                          "WHERE Login = @login AND PasswordHash = @pass";
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@pass", GetHashString(pass));
                    using (var reader = command.ExecuteReader())
                    {
                        reader.Read();
                        return _usersRepository.Get(reader.GetGuid(reader.GetOrdinal("UserId")));
                    }
                }
            }
        }
    }
}
