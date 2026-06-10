using FinalProjek.Interface;
using FinalProjek.Controler;
using FinalProjek.Model;
using FinalProjek.Helper;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace FinalProjek.View.Admin_View
{
    public partial class AddProductWiew : Form
    {
        // Use the designer-created openFileDialog1; do not redeclare a second field here
        private IProduk produkController;
        public AddProductWiew()
        {
            InitializeComponent();
            // openFileDialog1 is initialized in InitializeComponent(); do not re-create it here
            produkController = new ProdukController(); // pastikan sudah ada implementasi ProdukController yang sesuai dengan IProduk
        }

        private void btTambahGambar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedItem = openFileDialog1.FileName;
                //gambarProduk.BackgroundImageLayout = ImageLayout.Zoom;
                gambarProduk.SizeMode = PictureBoxSizeMode.Zoom;
                gambarProduk.Image = Image.FromFile(selectedItem);
            }
        }

        // Fixed: standard event handler signature and use the form's tbKategoriProduk control (not an extra parameter)
        private void BtSIMPAN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                MessageBox.Show("Pilih gambar terlebih dahulu!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Image GambarProduk = gambarProduk.Image;
            string namaProduk = tbNamaProduk.Text;
            int hargaProduk = int.Parse(tbHargaProduk.Text);
            int stokProduk = int.Parse(tbStokProduk.Text);
            string deskripsiProduk = rtbDeskripsiProduk.Text;

            // Use the Text property of the tbKategoriProduk control on the form
            int idKategori = int.Parse(tbKategoriProduk.Text);

            try
            {
                Produk produk = new Produk
                {
                    imageproduk = Imagehelper.ImageToBinary(GambarProduk),
                    nama_produk = namaProduk,
                    harga = hargaProduk,
                    stok = stokProduk,
                    deskripsi = deskripsiProduk,
                    id_kategori = idKategori
                };

                produkController.CreateProduk(produk);
                MessageBox.Show("Produk berhasil ditambahkaan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                var adminDashboard = new AdminDashboardView(produkController);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal Menambahkan Produk {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbKategoriProduk_TextChanged(object sender, EventArgs e)
        {

        }

        private void gambarProduk_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
