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
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
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
            produkController = produkInterface;
            LoadProducts();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btDashboar_Click(object sender, EventArgs e)
        {

        }

        public Panel CreateProductPanel(Produk produk)
        {
            Panel panel = new Panel
            {
                Size = new Size(175, 248),
                Margin = new Padding(3),
                BackgroundImage = Properties.Resources.Card,
                BackgroundImageLayout = ImageLayout.Zoom,
            };

            PictureBox displayProduct = new PictureBox
            {
                Location = new Point(32, 8),
                Size = new Size(114, 103),
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.Zoom,
            };

            // ✅ TAMBAHKAN INI:
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
                displayProduct.Image = Properties.Resources.Card; // default
            }

            Label namaProduk = new Label
            {
                Text = produk.nama_produk,
                Location = new Point(49, 114),
                Size = new Size(78, 23), //GANTIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
                BackColor = Color.Transparent,
                Font = new Font("Times New Roman", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            Label hargaProduk = new Label
            {
                Text = produk.harga.ToString(),
                Location = new Point(47, 140),
                Size = new Size(81, 19),
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(100, 60, 20),
                Font = new Font("Times New Roman", 8, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            Label labelStok = new Label
            {
                Location = new Point(53, 162),
                Size = new Size(46, 20),
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(100, 60, 20),
                Font = new Font("Times New Roman", 8, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            Label stokProduk = new Label
            {
                Text = produk.stok.ToString(),
                Location = new Point(92, 163),
                Size = new Size(25, 19),
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(100, 60, 20),
                Font = new Font("Times New Roman", 8, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            Button buttonEdit = new Button
            {
                Location = new Point(20, 200),
                Size = new Size(59, 37),
                Font = new Font("Times New Roman", 9, FontStyle.Regular),
                BackColor = Color.Wheat,
                Text = "Edit",
            };
            //buttonEdit.Click += (sender, e) => produkController.EditProduk();

            Button buttonHapus = new Button
            {
                Location = new Point(87, 200),
                Size = new Size(76, 37),
                Font = new Font("Times New Roman", 9, FontStyle.Regular),
                BackColor = Color.Red,
                ForeColor = Color.White,
                Text = "Hapus",
            };
            buttonHapus.Click += (sender, e) => produkController.GetAllProduk();

            panel.Controls.Add(displayProduct);
            panel.Controls.Add(namaProduk);
            panel.Controls.Add(hargaProduk);
            panel.Controls.Add(stokProduk);
            panel.Controls.Add(buttonEdit);
            panel.Controls.Add(buttonHapus);

            return panel;
        }

        public void LoadProducts()
        {
            flowLayoutPanel1.Controls.Clear();

            List<Produk> produks = produkController.GetAllProduk();

            foreach (Produk produk in produks)
            {
                Panel panelProduk = CreateProductPanel(produk);
                flowLayoutPanel1.Controls.Add(panelProduk);
            }
        }

        private void btTambahProduk_Click(object sender, EventArgs e)
        {
            AddProductWiew tambahProduk = new AddProductWiew();
            tambahProduk.Show();
        }

        private void btRefreshData_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btKelolaAkunUser_Click(object sender, EventArgs e)
        {
            KelolaAkunUser frmRegister = new KelolaAkunUser();
            frmRegister.ShowDialog();
        }

        private void Label_totalProduk_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
