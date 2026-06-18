using FinalProjek.Controler;
using FinalProjek.Model;
using FinalProjek.Interface;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProjek.View.Admin_View
{
    public partial class V_MonitorStok : Form
    {
        private ProdukController produkController;

        public V_MonitorStok()
        {
            InitializeComponent();
            produkController = new ProdukController();
            LoadDataStok();
        }

        public Panel CreateProductPanel(Produk produk)
        {
            Panel panel = new Panel
            {
                Size = new Size(1053, 92),
                Margin = new Padding(3),
                BackgroundImage = Properties.Resources.CardMonitorStokdalam,
                BackgroundImageLayout = ImageLayout.Zoom,
            };

            Label namaProduk = new Label
            {
                Text = produk.nama_produk,
                Location = new Point(24, 30),
                Size = new Size(454, 32),
                BackColor = Color.Transparent,
                Font = new Font("Times New Roman", 14, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
            };

            Label stokProduk = new Label
            {
                Text = produk.stok.ToString(),
                Location = new Point(535, 29),
                Size = new Size(49, 32),
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(100, 60, 20),
                Font = new Font("Times New Roman", 14, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            Button buttonRestok = new Button
            {
                Location = new Point(780, 25),
                Size = new Size(125, 43),
                Font = new Font("Times New Roman", 12, FontStyle.Regular),
                BackColor = Color.DarkOrange,
                ForeColor = Color.White,
                Text = "Restok",
                Cursor = Cursors.Hand
            };
            // REVISI: Menambahkan fungsi klik agar tombol Restok berfungsi
            buttonRestok.Click += (sender, e) => ProsesUpdateStok(produk, "tambah");

            Button buttonKurangi = new Button
            {
                Location = new Point(911, 25),
                Size = new Size(125, 43),
                Font = new Font("Times New Roman", 12, FontStyle.Regular),
                BackColor = Color.Red,
                ForeColor = Color.White,
                Text = "Kurangi",
                Cursor = Cursors.Hand
            };
            // REVISI: Menambahkan fungsi klik agar tombol Kurangi berfungsi
            buttonKurangi.Click += (sender, e) => ProsesUpdateStok(produk, "kurang");

            // panel.Controls.Add(displayProduct);
            panel.Controls.Add(namaProduk);
            // panel.Controls.Add(hargaProduk);
            panel.Controls.Add(stokProduk);
            panel.Controls.Add(buttonRestok);
            panel.Controls.Add(buttonKurangi);

            return panel;
        }

        public void LoadDataStok()
        {
            try
            {
                // Bersihkan kontrol lama
                flpMonitorStok.Controls.Clear();

                var produks = produkController.GetAllProduk();

                foreach (Produk produk in produks)
                {
                    Panel rowPanel = CreateProductPanel(produk);
                    flpMonitorStok.Controls.Add(rowPanel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data stok: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProsesUpdateStok(Produk produk, string aksi)
        {
            // Form input sederhana
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
                    nilaiInput = nilaiInput * -1;
                }

                bool sukses = produkController.UpdateStok(produk.id_produk, nilaiInput);

                if (sukses)
                {
                    MessageBox.Show("Stok berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataStok(); // Refresh
                }
                else
                {
                    MessageBox.Show("Gagal memperbarui stok.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            prompt.Dispose();
        }

        // ==============================================================
        // BAGIAN 2: LOGIKA NAVIGASI SIDEBAR (sesuai dengan designer)
        // ==============================================================
        private void btDashboar_Click(object sender, EventArgs e)
        {
            IProduk pc = new ProdukController();
            AdminDashboardView frm = new AdminDashboardView(pc);
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
            this.Hide();
        }

        private void btProduk_Click(object sender, EventArgs e)
        {
            V_Produk frm = new V_Produk();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
            this.Hide();
        }

        private void btKategori_Click(object sender, EventArgs e)
        {
            V_Kategori frm = new V_Kategori();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
            this.Hide();
        }

        private void btMonitorStok_Click(object sender, EventArgs e)
        {
            // Refresh halaman
            LoadDataStok();
        }

        private void btRiwayatTransaksi_Click(object sender, EventArgs e)
        {
            V_RiwayatTransaksi frm = new V_RiwayatTransaksi();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
            this.Hide();
        }

        private void btKelolaAkunUser_Click(object sender, EventArgs e)
        {
            V_KelolaAkunUserr frm = new V_KelolaAkunUserr();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
            this.Hide();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
            this.Hide();
        }

        private void btRestok_Click(object sender, EventArgs e)
        {

        }

        private void btKurangi_Click(object sender, EventArgs e)
        {

        }

        private void lbStok_Click(object sender, EventArgs e)
        {

        }

        private void lbNamaProduk_Click(object sender, EventArgs e)
        {

        }
    }
}