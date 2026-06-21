using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using FinalProjek.Controler;
using FinalProjek.Helper;
using FinalProjek.Interface;
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

        public V_Produk() : this(new ProdukController())
        {

        }

        private void btDashboar_Click(object sender, EventArgs e)
        {
            IProduk produkController = new ProdukController();
            AdminDashboardView frmDashboard = new AdminDashboardView(produkController);
            frmDashboard.FormClosed += (s, args) => this.Close();
            frmDashboard.Show();
            this.Hide();
        }

        private void btProduk_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btKategori_Click(object sender, EventArgs e)
        {
            V_Kategori frmKategori = new V_Kategori();
            frmKategori.FormClosed += (s, args) => this.Close();
            frmKategori.Show();
            this.Hide();
        }

        private void btMonitorStok_Click(object sender, EventArgs e)
        {
            V_MonitorStok frmMonitorStok = new V_MonitorStok();
            frmMonitorStok.FormClosed += (s, args) => this.Close();
            frmMonitorStok.Show();
            this.Hide();
        }

        private void btRiwayatTransaksi_Click(object sender, EventArgs e)
        {
            V_RiwayatTransaksi frmRiwayatTransaksi = new V_RiwayatTransaksi();
            frmRiwayatTransaksi.FormClosed += (s, args) => this.Close();
            frmRiwayatTransaksi.Show();
            this.Hide();
        }

        private void btKelolaAkunUser_Click(object sender, EventArgs e)
        {
            V_KelolaAkunUserr frmKelolaAkunUser = new V_KelolaAkunUserr();
            frmKelolaAkunUser.FormClosed += (s, args) => this.Close();
            frmKelolaAkunUser.Show();
            this.Hide();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            APPSession.Logout();
            Login frmLogin = new Login();
            frmLogin.Show();
            this.Close();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btTambahProduk_Click(object sender, EventArgs e)
        {
            AddProductWiew tambahProduk = new AddProductWiew();
            tambahProduk.FormClosed += (s, args) => LoadProducts();
            tambahProduk.ShowDialog();
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
                displayProduct.Image = Properties.Resources.Card;
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

            Label stokProduk = new Label
            {
                Text = "Stok: " + produk.stok.ToString(),
                Location = new Point(56, 204),
                Size = new Size(95, 25),
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
                Tag = produk,
            };
            buttonEdit.Click += BtnEdit_Click;

            Button buttonHapus = new Button
            {
                Location = new Point(103, 246),
                Size = new Size(76, 37),
                Font = new Font("Times New Roman", 9, FontStyle.Regular),
                BackColor = Color.Red,
                ForeColor = Color.White,
                Text = "Hapus",
                Tag = produk.id_produk,
            };
            buttonHapus.Click += BtnHapus_Click;

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

        // =========================================================
        // KODINGAN UNTUK TOMBOL EDIT (NAMA & HARGA)
        // =========================================================
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Produk produk = btn.Tag as Produk;

            if (produk == null) return;

            // Memanggil popout dialog baru yang memiliki 2 kolom (Nama dan Harga)
            if (ShowEditProdukDialog("Edit Produk", produk.nama_produk, produk.harga, out string newNama, out int newHarga))
            {
                // Mengecek apakah ada perubahan data
                if (newNama != produk.nama_produk || newHarga != produk.harga)
                {
                    if (string.IsNullOrEmpty(newNama))
                    {
                        MessageBox.Show("Nama produk tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Update data ke objek produk
                    produk.nama_produk = newNama;
                    produk.harga = newHarga;

                    // Simpan ke database
                    produkController.UpdateProduk(produk);

                    MessageBox.Show("Produk berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProducts();
                }
            }
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int idProduk = (int)btn.Tag;

            DialogResult confirm = MessageBox.Show("Yakin ingin menghapus produk ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                bool success = produkController.DeleteProduk(idProduk);
                if (success)
                {
                    MessageBox.Show("Produk berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProducts();
                }
                else
                {
                    MessageBox.Show("Gagal menghapus produk!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // =========================================================
        // POPOUT DIALOG BARU (MENDUKUNG 2 INPUT)
        // =========================================================
        private bool ShowEditProdukDialog(string title, string currentNama, int currentHarga, out string newNama, out int newHarga)
        {
            newNama = currentNama;
            newHarga = currentHarga;

            Form dialog = new Form();
            dialog.Text = title;
            dialog.Size = new Size(400, 250); // Ukuran form diperbesar ke bawah
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
            dialog.MaximizeBox = false;
            dialog.MinimizeBox = false;

            // 1. Kolom Input Nama Produk
            Label lblNama = new Label();
            lblNama.Text = "Nama Produk:";
            lblNama.Location = new Point(20, 20);
            lblNama.Size = new Size(350, 25);

            TextBox txtNama = new TextBox();
            txtNama.Text = currentNama;
            txtNama.Location = new Point(20, 50);
            txtNama.Size = new Size(350, 25);

            // 2. Kolom Input Harga Produk (Pakai NumericUpDown agar anti-error)
            Label lblHarga = new Label();
            lblHarga.Text = "Harga Produk (Rp):";
            lblHarga.Location = new Point(20, 90);
            lblHarga.Size = new Size(350, 25);

            NumericUpDown numHarga = new NumericUpDown();

            // PERBAIKAN: Set Maximum dan Minimum DULU sebelum memasukkan Value
            numHarga.Maximum = 100000000; // Batas maksimal harga 100 juta
            numHarga.Minimum = 0;
            numHarga.Value = currentHarga; // SEKARANG AMAN DARI ERROR!

            numHarga.Location = new Point(20, 120);
            numHarga.Size = new Size(350, 25);

            // Tombol OK dan Batal
            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.Location = new Point(200, 160);
            btnOK.Size = new Size(80, 30);
            btnOK.DialogResult = DialogResult.OK;

            Button btnCancel = new Button();
            btnCancel.Text = "Batal";
            btnCancel.Location = new Point(290, 160);
            btnCancel.Size = new Size(80, 30);
            btnCancel.DialogResult = DialogResult.Cancel;

            // Memasukkan semuanya ke dalam form Popout
            dialog.Controls.Add(lblNama);
            dialog.Controls.Add(txtNama);
            dialog.Controls.Add(lblHarga);
            dialog.Controls.Add(numHarga);
            dialog.Controls.Add(btnOK);
            dialog.Controls.Add(btnCancel);

            dialog.AcceptButton = btnOK; // Bisa tekan Enter untuk OK
            dialog.CancelButton = btnCancel; // Bisa tekan Esc untuk Batal

            // Jika user menekan tombol OK, ambil nilainya
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                newNama = txtNama.Text.Trim();
                newHarga = (int)numHarga.Value;
                return true;
            }

            return false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void Stok_Click(object sender, EventArgs e) { }
        private void NamaProduk_Click(object sender, EventArgs e) { }
    }
}