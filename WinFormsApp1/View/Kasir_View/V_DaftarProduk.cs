using FinalProjek.Model;   
using FinalProjek.Controler;

namespace FinalProjek.View.Kasir_View
{
    public partial class V_DaftarProduk : Form
    {
        private ProdukController produkController;

        public V_DaftarProduk()
        {
            InitializeComponent();
            produkController = new ProdukController();
            LoadProducts();
        }

        public void LoadProducts()
        {
            try
            {
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    control.Dispose();
                }
                flowLayoutPanel1.Controls.Clear();

                flowLayoutPanel1.SuspendLayout();

                List<Produk> produks = produkController.GetAllProduk();

                List<Control> panelList = new List<Control>();

                foreach (Produk produk in produks)
                {
                    Panel panelProduk = CreateProductPanel(produk);
                    panelList.Add(panelProduk);
                }

                flowLayoutPanel1.Controls.AddRange(panelList.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memuat data produk: " + ex.Message, "Sistem Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                flowLayoutPanel1.ResumeLayout();
            }
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
                Location = new Point(14, 15),
                Size = new Size(183, 147),
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
                
            }

            Label namaProduk = new Label
            {
                Text = produk.nama_produk,
                Location = new Point(8, 179),
                Size = new Size(197, 26),
                BackColor = Color.Transparent,
                Font = new Font("Times New Roman", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            Label hargaProduk = new Label
            {
                Text = "Rp " + produk.harga.ToString("N0"),
                Location = new Point(35, 219),
                Size = new Size(142, 25),
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(100, 60, 20),
                Font = new Font("Times New Roman", 11, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            Label stokProduk = new Label
            {
                Text = "Stok: " + produk.stok.ToString(),
                Location = new Point(47, 258),
                Size = new Size(101, 25),
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(100, 60, 20),
                Font = new Font("Times New Roman", 11, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };

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
                dashboardKasir.Show();
            }
            else
            {
                KasirDashboardView formBaru = new KasirDashboardView();
                formBaru.Show();
            }

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