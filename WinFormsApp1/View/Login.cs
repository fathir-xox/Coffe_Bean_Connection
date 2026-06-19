using FinalProjek.Controler;
using FinalProjek.Helper;
using FinalProjek.Interface;
using FinalProjek.Model;
using FinalProjek.View.Admin_View;
using FinalProjek.View.Kasir_View;


namespace FinalProjek.View
{
    public partial class Login : Form
    {
        private AuthController authcontroller;
        private readonly IProduk produkInterface;
        public Login()
        {
            InitializeComponent();
            authcontroller = new AuthController();
            txtPassword.UseSystemPasswordChar = true;
            produkInterface = new ProdukController();

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
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                User inputUser = new User
                {
                    username = txtUsername.Text,
                    password = txtPassword.Text
                };

                User loggedInUser = authcontroller.login(inputUser);

                if (loggedInUser != null)
                {
                    APPSession.SetUser(loggedInUser);

                    MessageBox.Show($"Selamat datang, {loggedInUser.full_name}!", "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (loggedInUser.role == UserRole.Admin)
                    {
                        AdminDashboardView formAdmin = new AdminDashboardView(produkInterface);
                        formAdmin.Show();
                    }
                    else if (loggedInUser.role == UserRole.Kasir)
                    {
                        KasirDashboardView formKasir = new KasirDashboardView();
                        formKasir.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistem Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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