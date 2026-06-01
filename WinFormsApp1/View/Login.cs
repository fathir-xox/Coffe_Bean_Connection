using FinalProjek.Controler;
using FinalProjek.Helper;
using FinalProjek.Model;
using FinalProjek.View.Admin_View;
using FinalProjek.View.Kasir_View;


namespace FinalProjek.View
{
    public partial class Login : Form
    {
        private AuthController _controller;
        public Login()
        {
            InitializeComponent();
            _controller = new AuthController();
            tbPasswordLogin.UseSystemPasswordChar = true;
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
            string username = tbUsernameLogin.Text;
            string password = tbPasswordLogin.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username dan password tidak boleh kosong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string hasPassword = PWhelper.HashPassword(password);
                User user = new User
                {
                    username = username,
                    password = hasPassword
                };

                var auth = _controller.login(user);
                if (auth != null)
                {
                    MessageBox.Show($"Login berhasil! Selamat datang {user.username}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    APPSession.SetUser(auth);

                    if (APPSession.CurrentUser.role == UserRole.Admin) //kalau admin, masuk ke dashboard admin, kalau user masuk ke dashboard kasir
                    {
                        AdminDashboardView adminView = new AdminDashboardView();
                        adminView.FormClosed += (s, args) => this.Close();
                        adminView.Show();
                        this.Hide();
                    }
                    else
                    {
                        KasirDashboardView kasirView = new KasirDashboardView();
                        kasirView.FormClosed += (s, args) => this.Close();
                        kasirView.Show();
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

        private void tbPasswordLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUsernameLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
