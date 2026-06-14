using FinalProjek.Controler;
using FinalProjek.Interface;
using FinalProjek.Model; // WAJIB: Untuk memanggil class Produk
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProjek.View.Admin_View
{
    public partial class V_MonitorStok : Form
    {
        // 1. Deklarasikan Controller
        private ProdukController produkController;

        public V_MonitorStok()
        {
            InitializeComponent();

            // 2. Inisialisasi controller dan jalankan pemuatan data
            produkController = new ProdukController();
            LoadDataStok();
        }

        // ==============================================================
        // BAGIAN 1: LOGIKA MONITOR STOK (TAMPILAN & UPDATE)
        // ==============================================================
        public void LoadDataStok()
        {
            try
            {
                // Bersihkan memori dari baris yang lama (PENTING: Pastikan Anda punya FlowLayoutPanel bernama flpMonitorStok)
                foreach (Control control in flpMonitorStok.Controls) control.Dispose();
                flpMonitorStok.Controls.Clear();

                flpMonitorStok.SuspendLayout();

                List<Produk> produks = produkController.GetAllProduk();

                foreach (Produk produk in produks)
                {
                    Panel rowPanel = CreateStokRow(produk);
                    flpMonitorStok.Controls.Add(rowPanel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data stok: " + ex.Message, "Sistem Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                flpMonitorStok.ResumeLayout();
            }
        }

        private Panel CreateStokRow(Produk produk)
        {
            // 1. Buat Baris Background
            Panel row = new Panel
            {
                Size = new Size(750, 50), // Sesuaikan dengan lebar layar monitor stok Anda
                Margin = new Padding(0, 0, 0, 10),
                BackColor = Color.OldLace // Warna krem sesuai tema
            };

            // 2. Nama Produk
            Label lblNama = new Label
            {
                Text = produk.nama_produk,
                Location = new Point(20, 15),
                Size = new Size(250, 25),
                Font = new Font("Segoe UI", 11, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleLeft
            };

            // 3. Stok Saat Ini (Warna Merah)
            Label lblStok = new Label
            {
                Text = produk.stok + " kg",
                Location = new Point(280, 15),
                Size = new Size(100, 25),
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.Crimson,
                TextAlign = ContentAlignment.MiddleLeft
            };

            // 4. Tombol Restok (Orange)
            Button btnRestok = new Button
            {
                Text = "Restok",
                Location = new Point(500, 10),
                Size = new Size(80, 30),
                BackColor = Color.Chocolate,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnRestok.FlatAppearance.BorderSize = 0;
            btnRestok.Click += (sender, e) => ProsesUpdateStok(produk, "tambah");

            // 5. Tombol Kurangi (Merah)
            Button btnKurangi = new Button
            {
                Text = "Kurangi",
                Location = new Point(590, 10),
                Size = new Size(80, 30),
                BackColor = Color.Red,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnKurangi.FlatAppearance.BorderSize = 0;
            btnKurangi.Click += (sender, e) => ProsesUpdateStok(produk, "kurang");

            row.Controls.Add(lblNama);
            row.Controls.Add(lblStok);
            row.Controls.Add(btnRestok);
            row.Controls.Add(btnKurangi);

            return row;
        }

        private void ProsesUpdateStok(Produk produk, string aksi)
        {
            // Popup Otomatis untuk Input Angka
            Form prompt = new Form()
            {
                Width = 350,
                Height = 180,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = aksi == "tambah" ? "Restok: " + produk.nama_produk : "Kurangi: " + produk.nama_produk,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false
            };

            Label textLabel = new Label() { Left = 20, Top = 20, Width = 300, Text = "Masukkan jumlah yang ingin di" + aksi + ":" };
            NumericUpDown inputAngka = new NumericUpDown() { Left = 20, Top = 50, Width = 290, Maximum = 10000, Minimum = 1 };
            Button confirmation = new Button() { Text = "Simpan", Left = 230, Width = 80, Top = 90, DialogResult = DialogResult.OK, BackColor = Color.Chocolate, ForeColor = Color.White, FlatStyle = FlatStyle.Flat };

            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputAngka);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            if (prompt.ShowDialog() == DialogResult.OK)
            {
                int nilaiInput = (int)inputAngka.Value;

                if (aksi == "kurang")
                {
                    if (produk.stok - nilaiInput < 0)
                    {
                        MessageBox.Show("Stok tidak bisa kurang dari 0!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    nilaiInput = nilaiInput * -1; // Ubah jadi minus agar stok berkurang
                }

                // Panggil fungsi UpdateStok di Controller
                bool sukses = produkController.UpdateStok(produk.id_produk, nilaiInput);

                if (sukses)
                {
                    MessageBox.Show("Stok berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataStok(); // Refresh tampilan stok otomatis
                }
            }

            prompt.Dispose();
        }


        // ==============================================================
        // BAGIAN 2: LOGIKA NAVIGASI SIDEBAR
        // ==============================================================
        private void btDashboar_Click(object sender, EventArgs e)
        {
            IProduk produkControllerInterface = new ProdukController();
            AdminDashboardView frmDashboard = new AdminDashboardView(produkControllerInterface);
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
            // Kosongkan saja. Karena ini adalah halaman Monitor Stok, tombol tidak perlu bereaksi jika diklik lagi.
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
            V_KelolaAkunUserr frmKelolaAkunUser = new V_KelolaAkunUserr();
            frmKelolaAkunUser.FormClosed += (s, args) => this.Close();
            frmKelolaAkunUser.Show();
            this.Hide();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.FormClosed += (s, args) => this.Close();
            frmLogin.Show();
            this.Hide();
        }
    }
}