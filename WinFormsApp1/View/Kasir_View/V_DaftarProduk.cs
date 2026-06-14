using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; // Wajib ditambahkan untuk memproses gambar (MemoryStream)
using System.Text;
using System.Windows.Forms;
using FinalProjek.Model;     // Memanggil class Produk
using FinalProjek.Controler; // Memanggil class ProdukController

namespace FinalProjek.View.Kasir_View
{
    public partial class V_DaftarProduk : Form
    {
        // 1. Deklarasikan controller di tingkat class
        private ProdukController produkController;

        public V_DaftarProduk()
        {
            InitializeComponent();

            // 2. Inisialisasi controller
            produkController = new ProdukController();

            // 3. Panggil LoadProducts saat form pertama kali dibuka
            LoadProducts();
        }

        public void LoadProducts()
        {
            try
            {
                // Mencegah Memory Leak: Bersihkan control lama dari memori
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    control.Dispose();
                }
                flowLayoutPanel1.Controls.Clear();

                // Mencegah Layar Berkedip: Tunda proses render UI
                flowLayoutPanel1.SuspendLayout();

                // Mengambil data dari database
                List<Produk> produks = produkController.GetAllProduk();

                // Menyiapkan list penampung untuk desain card
                List<Control> panelList = new List<Control>();

                foreach (Produk produk in produks)
                {
                    Panel panelProduk = CreateProductPanel(produk);
                    panelList.Add(panelProduk);
                }

                // Memasukkan semua card ke dalam FlowLayoutPanel sekaligus
                flowLayoutPanel1.Controls.AddRange(panelList.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memuat data produk: " + ex.Message, "Sistem Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Lanjutkan proses render UI
                flowLayoutPanel1.ResumeLayout();
            }
        }

        public Panel CreateProductPanel(Produk produk)
        {
            Panel panel = new Panel
            {
                Size = new Size(213, 305),
                Margin = new Padding(3), // Jarak antar card
                BackgroundImage = Properties.Resources.Card,
                BackgroundImageLayout = ImageLayout.Zoom,
            };

            PictureBox displayProduct = new PictureBox
            {
                Location = new Point(32, 8),
                Size = new Size(147, 122),
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.Zoom,
            };

            // Mengambil dan menampilkan gambar dari database secara aman
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
                // Jika ingin memberi gambar default saat stok tidak punya foto, uncomment baris ini:
                // displayProduct.Image = Properties.Resources.DefaultImage;
            }

            Label namaProduk = new Label
            {
                Text = produk.nama_produk,
                Location = new Point(8, 136),
                Size = new Size(197, 26),
                BackColor = Color.Transparent,
                Font = new Font("Times New Roman", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            Label hargaProduk = new Label
            {
                Text = "Rp " + produk.harga.ToString("N0"),
                Location = new Point(47, 167),
                Size = new Size(112, 25),
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(100, 60, 20),
                Font = new Font("Times New Roman", 11, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            Label stokProduk = new Label
            {
                Text = "Stok: " + produk.stok.ToString(),
                Location = new Point(52, 204),
                Size = new Size(101, 25),
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(100, 60, 20),
                Font = new Font("Times New Roman", 11, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            // Memasukkan semua elemen yang dibuat ke dalam Panel utama
            panel.Controls.Add(displayProduct);
            panel.Controls.Add(namaProduk);
            panel.Controls.Add(hargaProduk);
            panel.Controls.Add(stokProduk);

            return panel;
        }

        private void btTransaksi_Click(object sender, EventArgs e)
        {
            Form dashboardKasir = Application.OpenForms["KasirDashboardView"];

            if (dashboardKasir != null)
            {
                // Jika form dashboard sudah ada di memori, tampilkan kembali
                dashboardKasir.Show();
            }
            else
            {
                // Jaga-jaga jika form dashboard tidak ditemukan, buat yang baru
                KasirDashboardView formBaru = new KasirDashboardView();
                formBaru.Show();
            }

            // Tutup form Daftar Produk ini agar memorinya dibersihkan (menghindari memory leak karena banyak gambar)
            this.Close();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.FormClosed += (s, args) => this.Close();
            frmLogin.Show();
            this.Hide();
        }

        private void btRiwayatTransaksi_Click(object sender, EventArgs e)
        {
            Form formRiwayat = Application.OpenForms["V_RiwayatSaya"];

            if (formRiwayat != null)
            {
                formRiwayat.Show();
            }
            else
            {
                V_RiwayatSaya riwayatBaru = new V_RiwayatSaya();
                riwayatBaru.Show();
            }

            this.Hide();
        }
    }
}