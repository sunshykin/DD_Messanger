using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ChatterBox.Model;

namespace ChatterBox.DataLayer.RawSQL
{
    public class AttachsRepository : IAttachsRepository
    {
        private readonly string _connectionString;
        private readonly IUsersRepository _usersRepository;

        public AttachsRepository(string connectionString, IUsersRepository usersRepository = null)
        {
            _connectionString = connectionString;
            _usersRepository = usersRepository ?? new UsersRepository(_connectionString);
        }

        public void Delete(Guid id)
        {
            if (!AttachExists(id))
                throw new ArgumentException("Не удалось найти данный файл");
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM Attachs WHERE AttachId = @id";
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public Attach Get(Guid id)
        {
            if (!AttachExists(id))
                throw new ArgumentException("Не удалось найти данный файл");
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT TOP(1) * FROM Attachs WHERE AttachId = @id";
                    command.Parameters.AddWithValue("@id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        reader.Read();
                        return new Attach()
                        {
                            Id = reader.GetGuid(reader.GetOrdinal("AttachId")),
                            Path = reader.GetString(reader.GetOrdinal("Path")),
                            Sender = _usersRepository.Get(reader.GetGuid(reader.GetOrdinal("UserId")))
                        };
                    }
                }
            }
        }

        public bool AttachExists(Guid id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                ;
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT TOP(1) AttachId FROM Attachs WHERE AttachId = @id";
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
    }
}
