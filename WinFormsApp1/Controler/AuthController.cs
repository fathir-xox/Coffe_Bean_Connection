using FinalProjek.Database;
using Npgsql;
using FinalProjek.Model;
using FinalProjek.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FinalProjek.View.Admin_View;

namespace FinalProjek.Controler
{
    public class AuthController
    {
        private DbContext dbHelper;

        public AuthController()
        {
            dbHelper = new DbContext();
        }

        //internal static void logout(AdminDashboardView adminDashboardView)
        //{
        //    throw new NotImplementedException();
        //}

        public User? login(User user)
        {
            try
            {
                using (var conn = new NpgsqlConnection(dbHelper.connStr))
                {
                    conn.Open();

                    // TAMBAHKAN id_user DI SINI
                    string query = @"
                    SELECT id_user, ""role""::text, full_name, username, password FROM users 
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
                                // Urutan harus sama dengan SELECT di atas
                                int idUserDb = read.GetInt32(0);     // 0: id_user
                                string roleStr = read.GetString(1);  // 1: role

                                UserRole roleEnum = (UserRole)Enum.Parse(typeof(UserRole), roleStr, true);

                                User loggedInuser = new User
                                {
                                    id_user = idUserDb,              // Masukkan ID yang diambil dari DB
                                    role = roleEnum,
                                    full_name = read.GetString(2),   // 2: full_name
                                    username = read.GetString(3),    // 3: username
                                    password = read.GetString(4)     // 4: password
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
                throw new Exception("Gagal melakukan proses login: " + ex.Message);
            }
        }


        public bool Register(User user)
        {
            try
            {
                using (var conn = new NpgsqlConnection(dbHelper.connStr))
                {
                    conn.Open();

                    // Gunakan @role::role_enum agar parameter C# diterjemahkan ke Enum PostgreSQL
                    string query = @"
                            INSERT INTO users (username, password, ""role"", full_name, isactive) 
                            VALUES (@username, @password, @role::role_enum, @full_name, @isactive)";

                    string hashedPassword = PWhelper.HashPassword(user.password ?? string.Empty); //ada tambah an ?? string.Empty
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", user.username);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);

                        // user.role.ToString() akan mengubah Enum C# menjadi string "Admin" atau "Kasir"
                        cmd.Parameters.AddWithValue("@role", user.role.ToString());
                        cmd.Parameters.AddWithValue("@full_name", user.full_name);

                        // Saya biarkan @isactive true secara otomatis untuk setiap user baru
                        cmd.Parameters.AddWithValue("@isactive", true);

                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
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

                    // Ambil id_user, full_name, username, role, dan isactive
                    string query = @"SELECT id_user, full_name, username, ""role""::text, isactive FROM users ORDER BY id_user ASC";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Parsing Enum Role seperti yang Anda lakukan di fungsi Login
                            string roleStr = reader.GetString(3);
                            UserRole roleEnum = (UserRole)Enum.Parse(typeof(UserRole), roleStr, true);

                            User usr = new User
                            {
                                id_user = reader.GetInt32(0),
                                full_name = reader.GetString(1),
                                username = reader.GetString(2),
                                role = roleEnum,
                                // Jika ada property isactive di class User, Anda bisa tambahkan:
                                //isactive = reader.GetBoolean(4)
                                isactive = !reader.IsDBNull(4) && reader.GetBoolean(4)
                            };

                            listUser.Add(usr);
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
    }

}
