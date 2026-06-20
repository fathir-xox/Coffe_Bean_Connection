using FinalProjek.Controler;
using FinalProjek.Interface;
using FinalProjek.Model;

namespace FinalProjek.View.Admin_View
{
    public partial class V_KelolaAkunUserr : Form
    {
        private AuthController authController = new AuthController();

        public V_KelolaAkunUserr()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
            LoadData();
        }

        public Panel CreateUserPanel(User user)
        {
            Panel panel = new Panel
            {
                Size = new Size(1495, 92),
                Margin = new Padding(3),
                BackgroundImage = Properties.Resources.CardMonitorStokdalam,
                BackgroundImageLayout = ImageLayout.Stretch,
            };

            Label lbUsername = new Label
            {
                Text = "@" + user.username,
                Location = new Point(24, 30),
                Size = new Size(231, 32),
                BackColor = Color.Transparent,
                Font = new Font("Times New Roman", 14, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleLeft,
            };

            Label lbNamaLengkap = new Label
            {
                Text = user.full_name,
                Location = new Point(280, 29),
                Size = new Size(335, 32),
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(100, 60, 20),
                Font = new Font("Times New Roman", 14, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            Label lbRole = new Label
            {
                Text = user.role.ToString(),
                Location = new Point(728, 30),
                Size = new Size(143, 32),
                BackColor = Color.Transparent,
                Font = new Font("Times New Roman", 14, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            if (user.role.ToString().ToLower() == "admin")
                lbRole.ForeColor = Color.DarkGoldenrod;

            else
                lbRole.ForeColor = Color.DodgerBlue;

            Label lbStatus = new Label
            {
                Text = user.isactive ? "Aktif" : "Non Aktif",
                Location = new Point(988, 28),
                Size = new Size(144, 32),
                BackColor = Color.Transparent,
                ForeColor = user.isactive ? Color.MediumSeaGreen : Color.Red,
                Font = new Font("Times New Roman", 14, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            Button buttonEdit = new Button
            {
                Location = new Point(1210, 26),
                Size = new Size(125, 43),
                Font = new Font("Times New Roman", 12, FontStyle.Regular),
                BackColor = Color.DarkOrange,
                ForeColor = Color.White,
                Text = "Edit",
                Cursor = Cursors.Hand
            };
            buttonEdit.Click += (sender, e) => EditUser(user);

            Button buttonAksi = new Button
            {
                Location = new Point(1341, 26),
                Size = new Size(125, 43),
                Font = new Font("Times New Roman", 12, FontStyle.Regular),
                Cursor = Cursors.Hand
            };

            if (user.isactive)
            {
                buttonAksi.BackColor = Color.Red;
                buttonAksi.ForeColor = Color.White;
                buttonAksi.Text = "Hapus";
                buttonAksi.Click += (sender, e) => HapusUser(user);
            }
            else
            {
                buttonAksi.BackColor = Color.MediumSeaGreen;
                buttonAksi.ForeColor = Color.White;
                buttonAksi.Text = "Restore";
                buttonAksi.Click += (sender, e) => RestoreUserUI(user);

                buttonEdit.Enabled = false; // Matikan tombol edit jika user nonaktif
                buttonEdit.BackColor = Color.Gray;
            }

            panel.Controls.Add(lbUsername);
            panel.Controls.Add(lbNamaLengkap);
            panel.Controls.Add(lbRole);
            panel.Controls.Add(lbStatus);
            panel.Controls.Add(buttonEdit);
            panel.Controls.Add(buttonAksi);

            return panel;
        }

        private void LoadData()
        {
            try
            {
                flpKelolaUser.Controls.Clear();
                var users = authController.GetAllUsers();

                foreach (User user in users)
                {
                    Panel rowPanel = CreateUserPanel(user);
                    flpKelolaUser.Controls.Add(rowPanel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditUser(User user)
        {
            V_EditUser formEdit = new V_EditUser(user);
            if (formEdit.ShowDialog() == DialogResult.OK)
            {
                LoadData(); 
            }
        }

        private void HapusUser(User user)
        {
            DialogResult dialogResult = MessageBox.Show(
                $"Yakin ingin menonaktifkan user '{user.username}'? (Data tetap tersimpan di database)",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dialogResult == DialogResult.Yes)
            {
                bool berhasil = authController.DeleteUser(user.id_user);
                if (berhasil)
                {
                    MessageBox.Show("User berhasil dinonaktifkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); 
                }
                else
                {
                    MessageBox.Show("Gagal menonaktifkan user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void RestoreUserUI(User user)
        {
            DialogResult dialogResult = MessageBox.Show(
                $"Yakin ingin mengaktifkan kembali user '{user.username}'?",
                "Konfirmasi Restore",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.Yes)
            {
                bool berhasil = authController.RestoreUser(user.id_user);

                if (berhasil)
                {
                    MessageBox.Show("User berhasil diaktifkan kembali!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); 
                }
                else
                {
                    MessageBox.Show("Gagal mengaktifkan user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btDashboar_Click(object sender, EventArgs e)
        {
            IProduk produkController = new ProdukController();
            AdminDashboardView frmDashboard = new AdminDashboardView(produkController);
            frmDashboard.FormClosed += (s, args) => this.Close();
            frmDashboard.Show();
            this.Hide();
        }

        private void btProduk_Click(object sender, EventArgs e)
        {
            V_Produk frmProduk = new V_Produk();
            frmProduk.FormClosed += (s, args) => this.Close();
            frmProduk.Show();
            this.Hide();
        }

        private void btKategori_Click(object sender, EventArgs e)
        {
            V_Kategori frmKategori = new V_Kategori();
            frmKategori.FormClosed += (s, args) => this.Close();
            frmKategori.Show();
            this.Hide();
        }

        private void btMonitorStok_Click(object sender, EventArgs e)
        {
            V_MonitorStok frmMonitorStok = new V_MonitorStok();
            frmMonitorStok.FormClosed += (s, args) => this.Close();
            frmMonitorStok.Show();
            this.Hide();
        }

        private void btRiwayatTransaksi_Click(object sender, EventArgs e)
        {
            V_RiwayatTransaksi frmRiwayatTransaksi = new V_RiwayatTransaksi();
            frmRiwayatTransaksi.FormClosed += (s, args) => this.Close();
            frmRiwayatTransaksi.Show();
            this.Hide();
        }

        private void btKelolaAkunUser_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.FormClosed += (s, args) => this.Close();
            frmLogin.Show();
            this.Hide();
        }

        private void btTambahUser_Click(object sender, EventArgs e)
        {
            Register frmRegister = new Register();
            frmRegister.ShowDialog();
            LoadData();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lbUsername_Click(object sender, EventArgs e) { }
        private void lbNamaLengkapUser_Click(object sender, EventArgs e) { }
        private void lbRoleUser_Click(object sender, EventArgs e) { }
        private void lbstatusUser_Click(object sender, EventArgs e) { }
        private void btHapusUser_Click(object sender, EventArgs e) { }
    }
}