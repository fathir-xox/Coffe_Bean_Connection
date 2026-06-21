using FinalProjek.Controler;
using FinalProjek.Interface;
using FinalProjek.Model;

namespace FinalProjek.View.Admin_View
{
    public partial class V_TambahKategori : Form
    {
        private IKategori kategoriController;

        public V_TambahKategori()
        {
            InitializeComponent();
            kategoriController = new KategoriController();
        }

        private void btSIMPAN_Click(object sender, EventArgs e)
        {
            string namaKategori = tbNamaKategori.Text.Trim();
            string deskripsi = rtbDeskripsiKategori.Text.Trim();

            if (string.IsNullOrEmpty(namaKategori))
            {
                MessageBox.Show("Nama Kategori harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Kategori newKategori = new Kategori
                {
                    nama_kategori = namaKategori,
                    deskripsi = deskripsi,
                    isactive = true
                };

                kategoriController.CreateKategori(newKategori);

                MessageBox.Show("Kategori berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void V_TambahKategori_Load(object sender, EventArgs e) { }
    }
}