using FinalProjek.Controler;
using FinalProjek.Interface;
using FinalProjek.View;
using FinalProjek.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProjek.View.Admin_View
{
    public partial class V_KelolaAkunUserr : Form
    {
        private AuthController kelolauser = new AuthController();

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
                Size = new Size(1495, 92), // Sesuaikan tinggi dengan gambar background Anda
                Margin = new Padding(3),
                // UBAH "CardKelolaUser" dengan nama gambar background baris Anda di Resources
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
                ForeColor = Color.FromArgb(100, 60, 20), // Warna Coklat Kopi
                Font = new Font("Times New Roman", 14, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleLeft,
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

            // Menyesuaikan warna font berdasarkan Role
            if (user.role.ToString().ToLower() == "admin")
                lbRole.ForeColor = Color.DarkGoldenrod;
            else
                lbRole.ForeColor = Color.DodgerBlue;

            Label lbStatus = new Label
            {
                Text = user.isactive ? "Aktif" : "Tidak Aktif",
                Location = new Point(988, 28),
                Size = new Size(144, 32),
                BackColor = Color.Transparent,
                ForeColor = Color.MediumSeaGreen,
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

            Button buttonHapus = new Button
            {
                Location = new Point(1341, 26),
                Size = new Size(125, 43),
                Font = new Font("Times New Roman", 12, FontStyle.Regular),
                BackColor = Color.Red,
                ForeColor = Color.White,
                Text = "Hapus",
                Cursor = Cursors.Hand
            };
            buttonHapus.Click += (sender, e) => HapusUser(user);

            panel.Controls.Add(lbUsername);
            panel.Controls.Add(lbNamaLengkap);
            panel.Controls.Add(lbRole);
            panel.Controls.Add(lbStatus);
            panel.Controls.Add(buttonEdit);
            panel.Controls.Add(buttonHapus);

            return panel;
        }

        private void LoadData()
        {
            try
            {
                // Bersihkan kontrol lama pada FlowLayoutPanel
                flpKelolaUser.Controls.Clear();

                // Pastikan AuthController memiliki method GetAllUsers() yang mereturn List<User>
                var users = kelolauser.GetAllUsers();

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
            // Logika popup/form edit user di sini
            MessageBox.Show("Edit user: " + user.username);
        }

        private void HapusUser(User user)
        {
            // Logika konfirmasi hapus user di sini
            DialogResult dialogResult = MessageBox.Show($"Yakin ingin menghapus user {user.username}?", "Hapus User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                // kelolauser.DeleteUser(user.id_user);
                // LoadData();
                MessageBox.Show("User berhasil dihapus (Contoh).");
            }
        }

        // ==============================================================
        // LOGIKA NAVIGASI SIDEBAR
        // ==============================================================
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
            LoadData(); // Refresh halaman saat ini
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
            LoadData(); // Otomatis refresh list setelah nambah user
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        // ==============================================================
        // EVENT KOSONG (Kabel dari Designer agar tidak error)
        // ==============================================================
        private void lbUsername_Click(object sender, EventArgs e) { }
        private void lbNamaLengkapUser_Click(object sender, EventArgs e) { }
        private void lbRoleUser_Click(object sender, EventArgs e) { }
        private void lbstatusUser_Click(object sender, EventArgs e) { }
        private void btEditUser_Click(object sender, EventArgs e) { }
        private void btHapusUser_Click(object sender, EventArgs e) { }
    }
}