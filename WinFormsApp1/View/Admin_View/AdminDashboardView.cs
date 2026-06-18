using FinalProjek.Controler;
using FinalProjek.Helper;
using FinalProjek.Model;
using FinalProjek.Interface;
using FinalProjek.View;
using FinalProjek.View.Admin_View;
using FinalProjek.View.Kasir_View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; // Jangan lupa ini untuk MemoryStream gambar
using System.Text;
using System.Windows.Forms;

namespace FinalProjek.View.Admin_View
{
    public partial class AdminDashboardView : Form
    {
        private IProduk produkController;

        public AdminDashboardView(IProduk produkInterface)
        {
            InitializeComponent();

            if (produkInterface != null)
            {
                produkController = produkInterface;
            }
            else
            {
                produkController = new ProdukController();
            }

            LoadProducts();
        }

        public Panel CreateProductPanel(Produk produk)
        {
            Panel panel = new Panel
            {
                Size = new Size(213, 305),
                Margin = new Padding(3),
                BackgroundImage = Properties.Resources.Card,
                BackgroundImageLayout = ImageLayout.Zoom,
            };

            PictureBox displayProduct = new PictureBox
            {
                Location = new Point(19, 25),
                Size = new Size(173, 133),
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.Zoom,
            };

            if (produk.imageproduk != null && produk.imageproduk.Length > 0)
            {
                using (var ms = new MemoryStream(produk.imageproduk))
                {
                    var original = Image.FromStream(ms);
                    displayProduct.Image = new Bitmap(original);
                }
            }
            else
            {
                // displayProduct.Image = Properties.Resources.Card; // Ganti dengan gambar default kosong jika Anda punya
            }

            Label namaProduk = new Label
            {
                Text = produk.nama_produk,
                Location = new Point(8, 173),
                Size = new Size(197, 26),
                BackColor = Color.Transparent,
                Font = new Font("Times New Roman", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            Label hargaProduk = new Label
            {
                Text = "Rp " + produk.harga.ToString("N0"),
                Location = new Point(47, 214),
                Size = new Size(112, 25),
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(100, 60, 20),
                Font = new Font("Times New Roman", 11, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            Label stokProduk = new Label
            {
                Text = "Stok: " + produk.stok.ToString(),
                Location = new Point(52, 250),
                Size = new Size(101, 25),
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(100, 60, 20),
                Font = new Font("Times New Roman", 11, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            //Button buttonEdit = new Button
            //{
            //    Location = new Point(36, 246),
            //    Size = new Size(59, 37),
            //    Font = new Font("Times New Roman", 9, FontStyle.Regular),
            //    BackColor = Color.Wheat,
            //    Text = "Edit",
            //    Cursor = Cursors.Hand
            //};

            //Button buttonHapus = new Button
            //{
            //    Location = new Point(103, 246),
            //    Size = new Size(76, 37),
            //    Font = new Font("Times New Roman", 9, FontStyle.Regular),
            //    BackColor = Color.Red,
            //    ForeColor = Color.White,
            //    Text = "Hapus",
            //    Cursor = Cursors.Hand
            //};

            //buttonHapus.Click += (sender, e) =>
            //{
            //    DialogResult dialogResult = MessageBox.Show($"Apakah Anda yakin ingin menghapus produk '{produk.nama_produk}'?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        try
            //        {
            //            produkController.DeleteProduk(produk.id_produk);
            //            LoadProducts(); // Refresh panel setelah dihapus
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("Gagal menghapus produk: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //};

            panel.Controls.Add(displayProduct);
            panel.Controls.Add(namaProduk);
            panel.Controls.Add(hargaProduk);
            panel.Controls.Add(stokProduk);
            //panel.Controls.Add(buttonEdit);
            //panel.Controls.Add(buttonHapus);

            return panel;
        }

        public void LoadProducts()
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                List<Produk> produks = produkController.GetAllProduk();

                foreach (Produk produk in produks)
                {
                    Panel panelProduk = CreateProductPanel(produk);
                    flowLayoutPanel1.Controls.Add(panelProduk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memuat data produk: " + ex.Message, "Sistem Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btTambahProduk_Click(object sender, EventArgs e)
        {
            //AddProductWiew tambahProduk = new AddProductWiew();
            //tambahProduk.ShowDialog(); // Gunakan ShowDialog agar form admin menunggu
            //LoadProducts(); // Refresh data otomatis setelah form tambah ditutup!
        }

        private void btRefreshData_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void button1_Click(object sender, EventArgs e) // LOGOUT
        {
            Login frmLogin = new Login();
            frmLogin.Show();
            this.Hide(); // Cukup di-hide saja agar tidak crash
        }

        // =======================================================
        // MENU NAVIGASI (SIDEBAR)
        // =======================================================
        private void btKelolaAkunUser_Click(object sender, EventArgs e)
        {
            V_KelolaAkunUserr frmKelolaAkunUser = new V_KelolaAkunUserr();
            frmKelolaAkunUser.Show();
            this.Hide();
        }

        private void btRiwayatTransaksi_Click(object sender, EventArgs e)
        {
            V_RiwayatTransaksi frmRiwayatTransaksi = new V_RiwayatTransaksi();
            frmRiwayatTransaksi.Show();
            this.Hide();
        }

        private void btProduk_Click(object sender, EventArgs e)
        {
            V_Produk frmProduk = new V_Produk();
            frmProduk.Show();
            this.Hide();
        }

        private void btMonitorStok_Click(object sender, EventArgs e)
        {
            V_MonitorStok frmMonitorStok = new V_MonitorStok();
            frmMonitorStok.Show();
            this.Hide();
        }

        private void btKategori_Click(object sender, EventArgs e)
        {
            V_Kategori frmKategori = new V_Kategori();
            frmKategori.Show();
            this.Hide();
        }

        // =======================================================
        // EVENT KOSONG BAWAAN DESIGNER (Biarkan saja)
        // =======================================================
        private void label2_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void panel1_Paint_1(object sender, PaintEventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void button3_Click(object sender, EventArgs e) { }
        private void btDashboar_Click(object sender, EventArgs e) { }
        private void btHapus_Click(object sender, EventArgs e) { }
        private void Label_totalProduk_Click(object sender, EventArgs e)
        {

        }
        private void panel6_Paint(object sender, PaintEventArgs e) { }
        private void panel8_Paint(object sender, PaintEventArgs e) { }
        private void HargaProduk_Click(object sender, EventArgs e) { }
        private void Stok_Click(object sender, EventArgs e) { }

        private void Label_totalPenjualan_Click(object sender, EventArgs e)
        {

        }

        private void Label_totalPenghasilan_Click(object sender, EventArgs e)
        {

        }
    }
}