using FinalProjek.Database;
using Npgsql;
using FinalProjek.Model;
using FinalProjek.Helper;
using System;
using System.Collections.Generic;
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
                using (var conn = new NpgsqlConnection(dbHelper.connStr))
                {
                    conn.Open();

                    string query = @"
                        SELECT id_user, ""role""::text, full_name, username, password 
                        FROM users 
                        WHERE username = @username AND password = @password 
                        LIMIT 1";

                    string hashedPassword = PWhelper.HashPassword(user.password);

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", user.username);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);

                        using (var read = cmd.ExecuteReader())
                        {
                            if (read.Read())
                            {
                                int idUserDb = read.GetInt32(0);
                                string roleStr = read.GetString(1);
                                UserRole roleEnum = (UserRole)Enum.Parse(typeof(UserRole), roleStr, true);

                                User loggedInUser = new User
                                {
                                    id_user = idUserDb,
                                    role = roleEnum,
                                    full_name = read.GetString(2),
                                    username = read.GetString(3),
                                    password = read.GetString(4)
                                };
                                return loggedInUser;
                            }
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal melakukan proses login: " + ex.Message);
            }
        }
        public User login(string username, string password)
        {
            User tempUser = new User
            {
                username = username,
                password = password
            };

            return login(tempUser);
        }

        public bool Register(User user)
        {
            try
            {
                using (var conn = new NpgsqlConnection(dbHelper.connStr))
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO users (username, password, role, full_name, isactive) 
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
            catch (PostgresException ex) when (ex.SqlState == "23505")
            {
                throw new Exception("Username ini sudah dipakai. Silakan pilih username lain!");
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mendaftarkan akun baru: " + ex.Message);
            }
        }

        public List<User> GetAllUsers()
        {
            List<User> listUser = new List<User>();
            try
            {
                using (var conn = new NpgsqlConnection(dbHelper.connStr))
                {
                    conn.Open();

                    string query = @"
                        SELECT id_user, full_name, username, ""role""::text, isactive 
                        FROM users 
                        ORDER BY id_user ASC";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string roleStr = reader.GetString(3);
                            UserRole roleEnum = (UserRole)Enum.Parse(typeof(UserRole), roleStr, true);

                            listUser.Add(new User
                            {
                                id_user = reader.GetInt32(0),
                                full_name = reader.GetString(1),
                                username = reader.GetString(2),
                                role = roleEnum,
                                isactive = reader.GetBoolean(4)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil daftar user: " + ex.Message, "Sistem Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listUser;
        }

        public List<User> GetActiveUsers()
        {
            List<User> listUser = new List<User>();
            try
            {
                using (var conn = new NpgsqlConnection(dbHelper.connStr))
                {
                    conn.Open();

                    string query = @"
                        SELECT id_user, full_name, username, ""role""::text, isactive 
                        FROM users 
                        WHERE isactive = true
                        ORDER BY id_user ASC";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string roleStr = reader.GetString(3);
                            UserRole roleEnum = (UserRole)Enum.Parse(typeof(UserRole), roleStr, true);

                            listUser.Add(new User
                            {
                                id_user = reader.GetInt32(0),
                                full_name = reader.GetString(1),
                                username = reader.GetString(2),
                                role = roleEnum,
                                isactive = reader.GetBoolean(4)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil daftar user aktif: " + ex.Message, "Sistem Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listUser;
        }

        public bool DeleteUser(int id_user)
        {
            try
            {
                using (var conn = new NpgsqlConnection(dbHelper.connStr))
                {
                    conn.Open();
                    string query = "UPDATE users SET isactive = false WHERE id_user = @id";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id_user);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menonaktifkan user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool RestoreUser(int id_user)
        {
            try
            {
                using (var conn = new NpgsqlConnection(dbHelper.connStr))
                {
                    conn.Open();
                    string query = "UPDATE users SET isactive = true WHERE id_user = @id";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id_user);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengaktifkan user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateUser(User user)
        {
            try
            {
                using (var conn = new Npgsql.NpgsqlConnection(dbHelper.connStr))
                {
                    conn.Open();
                    string query = @"
                UPDATE users 
                SET username = @username, 
                    full_name = @full_name, 
                    ""role"" = @role::role_enum, 
                    isactive = @isactive 
                WHERE id_user = @id_user";

                    using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", user.username);
                        cmd.Parameters.AddWithValue("@full_name", user.full_name);
                        cmd.Parameters.AddWithValue("@role", user.role.ToString());
                        cmd.Parameters.AddWithValue("@isactive", user.isactive);
                        cmd.Parameters.AddWithValue("@id_user", user.id_user);

                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengupdate user: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}