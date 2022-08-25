using CustomerLIbrary.Entities;
using CustomerLIbrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CustomerLIbrary.Repositories
{
    public class NotesRepository : BaseRepository, IRepository<Notes>
    {
        public void Create(Notes entity)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO [CustomerLib_Demin].[dbo].[Notes] (CustomerId, Note) VALUES (@CustomerId,@Note)", connection);

                var customerIdParam = new SqlParameter("@CustomerId", SqlDbType.Int) { Value = entity.CustomerId };
                var noteParam = new SqlParameter("@Note", SqlDbType.NVarChar, 255) { Value = entity.Note };

                command.Parameters.Add(customerIdParam);
                command.Parameters.Add(noteParam);

                command.ExecuteNonQuery();
            }
        }     

        public Notes Read(string entityCode)
        {
            using (var connection = GetConnection()) {
                connection.Open();

                var command = new SqlCommand("SELECT * FROM [CustomerLib_Demin].[dbo].[Notes] WHERE NoteId = @NoteId", connection);

                var noteIdParam = new SqlParameter("@NoteId", SqlDbType.Int) { Value = entityCode };

                command.Parameters.Add(noteIdParam);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Notes
                        {
                            NoteId = Convert.ToInt32(reader["NoteId"]),
                            CustomerId = Convert.ToInt32(reader["CustomerId"]),
                            Note = reader["Note"].ToString()
                        };
                    }
                    return null;
                }
            }
        }

        public void Update(Notes entity)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                var command = new SqlCommand("UPDATE [CustomerLib_Demin].[dbo].[Notes] SET CustomerId = @CustomerId, Note = @Note WHERE NoteId = @NoteId", connection);

                var noteIdParam = new SqlParameter("@NoteId", SqlDbType.Int) { Value = entity.NoteId };
                var customerIdParam = new SqlParameter("@CustomerId", SqlDbType.Int) { Value = entity.CustomerId };
                var noteParam = new SqlParameter("@Note", SqlDbType.NVarChar, 255) { Value = entity.Note };

                command.Parameters.Add(noteIdParam);
                command.Parameters.Add(customerIdParam);
                command.Parameters.Add(noteParam);

                command.ExecuteNonQuery();
            }
        }

        public void Delete(string entityCode)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                var command = new SqlCommand("DELETE [CustomerLib_Demin].[dbo].[Notes] WHERE NoteId = @NoteId", connection);

                var noteIdParam = new SqlParameter("@NoteId", SqlDbType.Int) { Value = entityCode };

                command.Parameters.Add(noteIdParam);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteAll(string customerId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                var command = new SqlCommand("DELETE [CustomerLib_Demin].[dbo].[Notes] WHERE CustomerId = @CustomerId", connection);

                var noteIdParam = new SqlParameter("@CustomerId", SqlDbType.Int) { Value = customerId };

                command.Parameters.Add(noteIdParam);

                command.ExecuteNonQuery();
            }
        }

        public List<Notes> GetAll(string customerId)
        {
            var notes = new List<Notes>();
            using (var connection = GetConnection())
            {
                connection.Open();

                var command = new SqlCommand("SELECT * FROM [CustomerLib_Demin].[dbo].[Notes] WHERE CustomerId = @CustomerId", connection);

                var noteIdParam = new SqlParameter("@CustomerId", SqlDbType.Int) { Value = customerId };

                command.Parameters.Add(noteIdParam);

                using (var reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        notes.Add( new Notes
                        {
                            NoteId = Convert.ToInt32(reader["NoteId"]),
                            CustomerId = Convert.ToInt32(reader["CustomerId"]),
                            Note = reader["Note"].ToString()
                        });
                    }
                }
            }
            return notes;
        }
    }
}
