using FinalProjek.Interface;
using FinalProjek.Controler;
using FinalProjek.Model;
using FinalProjek.Helper;


namespace FinalProjek.View.Admin_View
{
    public partial class AddProductWiew : Form
    {
        private OpenFileDialog openFileDialog;
        private IProduk produkController;
        public AddProductWiew()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            produkController = new ProdukController(); // pastikan sudah ada implementasi ProdukController yang sesuai dengan IProduk
        }

        private void btTambahGambar_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedItem = openFileDialog.FileName;
                //gambarProduk.BackgroundImageLayout = ImageLayout.Zoom;
                gambarProduk.SizeMode = PictureBoxSizeMode.Zoom;
                gambarProduk.Image = Image.FromFile(selectedItem);
            }
        }

        private void btSIMPAN_Click(object sender, EventArgs e, object tbKategoriProduk)
        {
            if (string.IsNullOrEmpty(openFileDialog.FileName))
            {
                MessageBox.Show("Pilih gambar terlebih dahulu!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Image GambarProduk = gambarProduk.Image;
            string namaProduk = tbNamaProduk.Text;
            int hargaProduk = int.Parse(tbHargaProduk.Text);
            int stokProduk = int.Parse(tbStokProduk.Text);
            string deskripsiProduk = rtbDeskripsiProduk.Text;

            try
            {
                Produk produk = new Produk
                {
                    imageproduk = Imagehelper.ImageToBinary(GambarProduk),
                    nama_produk = namaProduk,
                    harga = hargaProduk,
                    stok = stokProduk,
                    deskripsi = deskripsiProduk,
                    id_kategori = int.Parse(tbKategoriProduk.Text)
                };

                produkController.CreateProduk(produk);
                MessageBox.Show("Produk berhasil ditambahkaan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                var adminDashboard = new AdminDashboardView(produkController);
            } catch (Exception ex)
            {
                MessageBox.Show($"Gagal Menambahkan Produk {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
