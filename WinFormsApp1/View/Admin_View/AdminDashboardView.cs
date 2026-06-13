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
            this.Close();
            V_EditProduk frmEditProduk = new V_EditProduk();
            frmEditProduk.ShowDialog();
        }

        private void btDashboar_Click(object sender, EventArgs e)
        {
            this.Close();
            IProduk produkController = new ProdukController(); // buat instance controller
            AdminDashboardView frmDashboard = new AdminDashboardView(produkController);
            frmDashboard.ShowDialog();
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
                Location = new Point(32, 8),
                Size = new Size(147, 122),
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
                displayProduct.Image = Properties.Resources.Card; // default
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
                Text = "Rp" + produk.harga.ToString("N0"),
                Location = new Point(47, 167),
                Size = new Size(112, 25),
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(100, 60, 20),
                Font = new Font("Times New Roman", 11, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            Label labelStok = new Label
            {
                Location = new Point(53, 202),
                Size = new Size(58, 25),
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(100, 60, 20),
                Font = new Font("Times New Roman", 11, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            Label stokProduk = new Label
            {
                Text = "Stok: " + produk.stok.ToString(),
                Location = new Point(107, 202),
                Size = new Size(34, 25),
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(100, 60, 20),
                Font = new Font("Times New Roman", 11, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            Button buttonEdit = new Button
            {
                Location = new Point(36, 246),
                Size = new Size(59, 37),
                Font = new Font("Times New Roman", 9, FontStyle.Regular),
                BackColor = Color.Wheat,
                Text = "Edit",
            };
            //buttonEdit.Click += (sender, e) => produkController.EditProduk();

            Button buttonHapus = new Button
            {
                Location = new Point(103, 246),
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
            //panel.Controls.Add()

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

        private void btHapus_Click(object sender, EventArgs e)
        {
            
        }

        private void btRefreshData_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btKelolaAkunUser_Click(object sender, EventArgs e)
        {
            this.Close();
            V_KelolaAkunUserr frmKelolaAkunUser = new V_KelolaAkunUserr();
            frmKelolaAkunUser.ShowDialog();
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

        private void btRiwayatTransaksi_Click(object sender, EventArgs e)
        {
            this.Close();
            V_RiwayatTransaksi frmRiwayatTransaksi = new V_RiwayatTransaksi();
            frmRiwayatTransaksi.ShowDialog();
        }

        private void btProduk_Click(object sender, EventArgs e)
        {
            this.Close();
            V_Produk frmProduk = new V_Produk();
            frmProduk.ShowDialog();
        }

        private void btMonitorStok_Click(object sender, EventArgs e)
        {
            this.Close();
            V_MonitorStok frmMonitorStok = new V_MonitorStok();
            frmMonitorStok.ShowDialog();
        }

        private void btKategori_Click(object sender, EventArgs e)
        {
            this.Close();
            V_Kategori frmKategori = new V_Kategori();
            frmKategori.ShowDialog();
        }

        private void HargaProduk_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuthController.logout(this);
        }

    }
}
