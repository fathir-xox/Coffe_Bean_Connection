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

                    // Gunakan role::text agar database mengirimkan enum sebagai string
                    // Asumsi nama tabel di database adalah "users"
                    string query = @"
                            SELECT ""role""::text, full_name, username, password FROM ""user"" 
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
                                // Ambil string role dari database ("Admin" atau "Kasir")
                                string roleStr = read.GetString(0);

                                // Konversi string tersebut menjadi Enum UserRole (true = mengabaikan huruf besar/kecil)
                                UserRole roleEnum = (UserRole)Enum.Parse(typeof(UserRole), roleStr, true);

                                User loggedInuser = new User
                                {
                                    role = roleEnum,  // Masukkan tipe Enum ke properti model
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
                            INSERT INTO ""user"" (username, password, ""role"", full_name, isactive) 
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
    }

}
