using FinalProjek.DatabaseHelper;
using FinalProjek.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProjek.Controler
{
    private class controler
    {
        private DatabaseHelper.DatabaseHelper dbHelper;

        public controler()
        {
            dbHelper = new DatabaseHelper.DatabaseHelper();
        }
        
        public User login(User user)
        {
            try
            {
                using (var conn = new NpgsqlConection(dbHelper.connStr))
                {
                    conn.Open();
                    string query = @"
                            SELECT role,full_name, username, password FROM users 
                            WHERE username = @username AND password = @password LIMIT 1";

                    string hashedPassword = PWhelper.HashPassword(user.password);

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", user.Username);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);

                        using(var read = cmd.ExecuteReader())
                        {
                            if (read.Read)
                            {
                                string role = read.GetString(0);
                                UserRole roleEnum = (UserRole)Enum.Parse(typeof(UserRole), role, true);

                                User loggedInuser = new User
                                {
                                    Role = roleEnum,
                                    Full_name = read.GetString(1),
                                    Username = read.GetString(2),
                                    Password = read.GetString(3)
                                };
                                return loggedInuser;
                            }

                            return null;
                        }
                    }                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"LOGIN ERROR: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool Register(User user)
        {
            try
            {
                using (var conn = new NpgsqlConection(dbHelper.connStr))
                {
                    conn.Open();
                    string query = @"
                            INSERT INTO users (username, password, role, full_name) 
                            VALUES (@username, @password, @role, @full_name)";
                    string hashedPassword = PWhelper.HashPassword(user.password);
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", user.Username);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.Parameters.AddWithValue("@role", user.Role.ToString());
                        cmd.Parameters.AddWithValue("@full_name", user.Full_name);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"REGISTER ERROR: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
}
