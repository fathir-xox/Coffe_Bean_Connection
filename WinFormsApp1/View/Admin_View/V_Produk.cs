using FinalProjek.Controler;
using FinalProjek.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FinalProjek.Model;

namespace FinalProjek.View.Admin_View
{
    public partial class V_Produk : Form
    {
        IProduk produkController;
        public V_Produk(IProduk produkInterface)
        {
            InitializeComponent();
            produkController = produkInterface;
            LoadProducts();
        }

        public V_Produk()
        {
        }

        private void btDashboar_Click(object sender, EventArgs e)
        {
            this.Close();
            IProduk produkController = new ProdukController(); // buat instance controller
            AdminDashboardView frmDashboard = new AdminDashboardView(produkController);
            frmDashboard.ShowDialog();
        }

        private void btProduk_Click(object sender, EventArgs e)
        {

        }

        private void btKategori_Click(object sender, EventArgs e)
        {
            this.Close();
            V_Kategori frmKategori = new V_Kategori();
            frmKategori.ShowDialog();
        }

        private void btMonitorStok_Click(object sender, EventArgs e)
        {
            this.Close();
            V_MonitorStok frmMonitorStok = new V_MonitorStok();
            frmMonitorStok.ShowDialog();
        }

        private void btRiwayatTransaksi_Click(object sender, EventArgs e)
        {
            this.Close();
            V_RiwayatTransaksi frmRiwayatTransaksi = new V_RiwayatTransaksi();
            frmRiwayatTransaksi.ShowDialog();
        }

        private void btKelolaAkunUser_Click(object sender, EventArgs e)
        {
            this.Close();
            V_KelolaAkunUserr frmKelolaAkunUser = new V_KelolaAkunUserr();
            frmKelolaAkunUser.ShowDialog();
        }

        private void NamaProduk_Click(object sender, EventArgs e)
        {

        }

        private void btTambahProduk_Click(object sender, EventArgs e)
        {

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

        private void btLogout_Click(object sender, EventArgs e)
        {
            AuthController.logout(this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
