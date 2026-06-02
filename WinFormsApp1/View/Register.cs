using FinalProjek.Controler;
using FinalProjek.Helper;
using FinalProjek.Model;



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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string fullName = tbFullNameRegister.Text;
                string username = tbUsernameRegister.Text;
                string password = PWhelper.HashPassword(tbPasswordRegister.Text); //untuk mengamankan password, kita hash dulu sebelum disimpan ke database

                if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Semua field harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    User userRegister = new User //User di model
                    {
                        full_name = fullName,
                        username = username,
                        password = password,
                        role = UserRole.Kasir //dimodel ini sudah ada enum UserRole, jadi langsung bisa dipakai (Admin, Kasir)
                    };
                    var success = _controller.Register(userRegister);
                    if (success)
                    {
                        MessageBox.Show("Registrasi berhasil", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Login loginView = new Login(); // setelah registrasi berhasil, langsung arahkan ke halaman login
                        //loginView.FormClosed += (s, args) => this.Close(); // pastikan form register juga tertutup saat form login ditutup
                        //this.Hide(); // sembunyikan form register
                        //loginView.Show();
                        this.Close(); // langsung tutup form register setelah berhasil, biarkan user yang buka form login lagi jika mau login
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
