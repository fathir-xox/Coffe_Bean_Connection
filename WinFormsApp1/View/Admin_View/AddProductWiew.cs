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
                gambarProduk.BackgroundImageLayout = ImageLayout.Zoom;
                gambarProduk.Image = Image.FromFile(selectedItem);
            }
        }

        private void btSIMPAN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(openFileDialog.FileName))
            {
                MessageBox.Show("Pilih gambar terlebih dahulu!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Image GambarProduk = gambarProduk.Image;
            string namaProduk = tbNamaProduk.Text;
            int hargaProduk = int.Parse(tbHargaProduk.Text);
            int stokProduk = int.Parse(tbStokProduk.Text);

            try
            {
                Produk produk = new Produk
                {
                    image = Imagehelper.ImageToBinary(GambarProduk),
                    nama_produk = namaProduk,
                    harga = hargaProduk,
                    stok = stokProduk,
                    id_user = APPSession.CurrentUser.id_user,
                };

                produkController.CreateProduk(produk);
            } catch (Exception ex)
            {
                MessageBox.Show($"Gagal Menambahkan Produk {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
