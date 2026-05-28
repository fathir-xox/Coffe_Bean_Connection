using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FinalProjek.Controler;
using FinalProjek.Helper;
using FinalProjek.Model;


namespace FinalProjek.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username dan password tidak boleh kosong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                string hasPassword = PWhelper.HashPassword(password);
                UserModel user = new UserModel
                {
                    UserName = username,
                    password = hasPassword
                };

                var auth = Controler.Login(user);
                if (auth != null)
                {
                    MessageBox.Show($"Login berhasil! Selamat datang {user.UserName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    AppSession.SetUser(auth);

                    if (AppSession.CurrentUser.Role == UserRole.admin)
                    {
                        AdminDashboardView admin = new AdminDashboardView();
                        admin.FormClosed += (s, args) => this.Close();
                        admin.Show();
                        this.Hide();
                    }
                    else
                    {
                        UserDashboardView userView = new UserDashboardView();
                        admin.FormClosed += (s, args) => this.Close();
                        admin.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Login gagal. Periksa username dan password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal Login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
