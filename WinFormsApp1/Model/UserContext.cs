using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using FinalProjek.DatabaseHelper;

namespace FinalProjek.Model
{
    public class UserContext
    {
        public List<User> GetAllUsers()
        {
            List<User> list = new List<User>();
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "SELECT idUser, username, password, role, namaLengkap, isActive FROM users",
                conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new.User(
                   reader.GetInt32(0),
                   reader.GetString(1),
                   reader.GetString(2),
                   reader.GetString(3),
                   reader.GetString(4),
                   reader.GetBoolean(5)
                ));
            }
            return list;
        }

        public void AddUser(User user)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "INSERT INTO users (username, password, role, namaLengkap, isActive) " +
                "VALUES (@username, @password, @role, @namaLengkap, @isActive)",
                conn);
            cmd.Parameters.AddWithValue("username", user.username);
            cmd.Parameters.AddWithValue("password", user.password);
            cmd.Parameters.AddWithValue("role", user.role);
            cmd.Parameters.AddWithValue("namaLengkap", user.namaLengkap);
            cmd.Parameters.AddWithValue("isActive", user.isActive);
            cmd.ExecuteNonQuery();
        }

        public void UpdateUser(User user)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "UPDATE users SET username = @username, password = @password, role = @role, " +
                "namaLengkap = @namaLengkap, isActive = @isActive WHERE idUser = @idUser",
                conn);
            cmd.Parameters.AddWithValue("username", user.username);
            cmd.Parameters.AddWithValue("password", user.password);
            cmd.Parameters.AddWithValue("role", user.role);
            cmd.Parameters.AddWithValue("namaLengkap", user.namaLengkap);
            cmd.Parameters.AddWithValue("isActive", user.isActive);
            cmd.Parameters.AddWithValue("idUser", user.idUser);
            cmd.ExecuteNonQuery();
        }

        public void DeleteUser(int idUser)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "DELETE FROM users WHERE idUser = @idUser",
                conn);
            cmd.Parameters.AddWithValue("idUser", idUser);
            cmd.ExecuteNonQuery();
        }
    }
}
