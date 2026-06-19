using FinalProjek.Controler;
using FinalProjek.Model;
using System;
using System.Windows.Forms;

namespace FinalProjek.View
{
    public partial class Register : Form
    {
        private AuthController _controller;
        public Register()
        {
            InitializeComponent();
            _controller = new AuthController();
            tbPasswordRegister.UseSystemPasswordChar = true;
        }

        private void label2_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string fullName = tbFullNameRegister.Text;
                string username = tbUsernameRegister.Text;

                string password = tbPasswordRegister.Text;

                if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Semua field harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    User userRegister = new User
                    {
                        full_name = fullName,
                        username = username,
                        password = password, 
                        role = UserRole.Kasir 
                    };

                    var success = _controller.Register(userRegister);
                    if (success)
                    {
                        MessageBox.Show("Registrasi berhasil! Silakan Login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal melakukan pendaftaran: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}