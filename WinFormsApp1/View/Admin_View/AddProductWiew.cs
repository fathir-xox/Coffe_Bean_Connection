using FinalProjek.Controler;
using FinalProjek.Interface;
using FinalProjek.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProjek.View.Admin_View
{
    public partial class AddProductWiew : Form
    {
        private IProduk produkController;
        private IKategori kategoriController;
        private byte[] imageBytes;

        public AddProductWiew()
        {
            InitializeComponent();
            produkController = new ProdukController();
            kategoriController = new KategoriController();
            LoadKategoriCombo();

            btnTambahGambar.Click += btnTambahGambar_Click;
            btnSimpan.Click += btnSimpan_Click;
        }

        private void LoadKategoriCombo()
        {
            var listKategori = kategoriController.GetActiveKategori();
            cbIdKategori.DataSource = listKategori;
            cbIdKategori.DisplayMember = "nama_kategori";
            cbIdKategori.ValueMember = "id_kategori";
        }

        private void btnTambahGambar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Pilih Gambar Produk";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Image img = Image.FromFile(ofd.FileName);
                    pbGambar.Image = img;

                    using (var ms = new System.IO.MemoryStream())
                    {
                        img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        imageBytes = ms.ToArray();
                    }
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nama = tbNamaProduk.Text.Trim();
            string hargaText = tbHargaProduk.Text.Trim();
            string stokText = tbStokProduk.Text.Trim();
            string deskripsi = rtbDeskripsi.Text.Trim();

            if (string.IsNullOrEmpty(nama))
            {
                MessageBox.Show("Nama Produk harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(hargaText, out double harga) || harga <= 0)
            {
                MessageBox.Show("Harga Produk harus berupa angka positif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(stokText, out int stok) || stok < 0)
            {
                MessageBox.Show("Stok Produk harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbIdKategori.SelectedValue == null)
            {
                MessageBox.Show("Pilih Kategori!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Produk produk = new Produk
                {
                    nama_produk = nama,
                    harga = (int)harga,
                    stok = stok,
                    deskripsi = deskripsi,
                    id_kategori = (int)cbIdKategori.SelectedValue,
                    imageproduk = imageBytes
                };

                produkController.CreateProduk(produk);
                MessageBox.Show("Produk berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}