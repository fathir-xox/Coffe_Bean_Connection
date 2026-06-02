using FinalProjek.Database;
using Npgsql;
using FinalProjek.Model;
using FinalProjek.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinalProjek.Controler
{
    public class AuthController
    {
        private DbContext dbHelper;

        public AuthController()
        {
           dbHelper = new DbContext();
        }

        public User login(User user)
        {
            try
            {
                using NpgsqlConnection conn = new NpgsqlConnection(dbHelper.connStr);
                {
                    conn.Open();
                    string query = @"
                            SELECT role,full_name, username, password FROM ""user"" 
                            WHERE username = @username AND password = @password LIMIT 1";

                    string hashedPassword = PWhelper.HashPassword(user.password);

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", user.username);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);

                        using (var read = cmd.ExecuteReader())
                        {
                            if (read.Read())
                            {
                                string role = read.GetString(0);
                                UserRole roleEnum = (UserRole)Enum.Parse(typeof(UserRole), role, true);

                                User loggedInuser = new User
                                {
                                    role = roleEnum,
                                    full_name = read.GetString(1),
                                    username = read.GetString(2),
                                    password = read.GetString(3)
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
                using (var conn = new NpgsqlConnection(dbHelper.connStr))
                {
                    conn.Open();
                    string query = @"INSERT INTO ""user"" (username, password, role, full_name, isactive) 
                    VALUES (@username, @password, @role::role_enum, @full_name, @isactive)";

                    string hashedPassword = PWhelper.HashPassword(user.password);
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", user.username);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.Parameters.AddWithValue("@role", user.role.ToString());
                        cmd.Parameters.AddWithValue("@full_name", user.full_name);
                        cmd.Parameters.AddWithValue("@isactive", true);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"REGISTER ERROR: {ex}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
    }
}
