using FinalProjek.Controler;
using FinalProjek.Interface;
using FinalProjek.Model;
using System;
using System.Windows.Forms;

namespace FinalProjek.View.Admin_View
{
    public partial class V_MonitorStok : Form
    {
        private ProdukController produkController;

        public V_MonitorStok()
        {
            InitializeComponent();
            produkController = new ProdukController();
            LoadData();
            // Pasang event klik untuk tombol di DataGridView
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void LoadData()
        {
            // Ambil semua produk aktif
            var produkList = produkController.GetAllProduk();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = produkList;

            // Sembunyikan kolom yang tidak perlu
            if (dataGridView1.Columns["id_produk"] != null)
                dataGridView1.Columns["id_produk"].Visible = false;
            if (dataGridView1.Columns["harga"] != null)
                dataGridView1.Columns["harga"].Visible = false;
            if (dataGridView1.Columns["deskripsi"] != null)
                dataGridView1.Columns["deskripsi"].Visible = false;
            if (dataGridView1.Columns["imageproduk"] != null)
                dataGridView1.Columns["imageproduk"].Visible = false;
            if (dataGridView1.Columns["is_active"] != null)
                dataGridView1.Columns["is_active"].Visible = false;
            if (dataGridView1.Columns["created_at"] != null)
                dataGridView1.Columns["created_at"].Visible = false;
            if (dataGridView1.Columns["updated_at"] != null)
                dataGridView1.Columns["updated_at"].Visible = false;
            if (dataGridView1.Columns["id_kategori"] != null)
                dataGridView1.Columns["id_kategori"].Visible = false;

            // Atur header kolom
            if (dataGridView1.Columns["nama_produk"] != null)
                dataGridView1.Columns["nama_produk"].HeaderText = "PRODUK";
            if (dataGridView1.Columns["stok"] != null)
                dataGridView1.Columns["stok"].HeaderText = "STOK";
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Ambil id_produk dan stok dari baris yang dipilih
            int id_produk = (int)dataGridView1.Rows[e.RowIndex].Cells["id_produk"].Value;
            string namaProduk = dataGridView1.Rows[e.RowIndex].Cells["nama_produk"].Value.ToString();
            int stokSaatIni = (int)dataGridView1.Rows[e.RowIndex].Cells["stok"].Value;

            // Cek kolom mana yang diklik
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Restok")
            {
                DialogResult result = MessageBox.Show($"Tambah stok produk '{namaProduk}' sebanyak 1?", "Restok", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (produkController.UpdateStok(id_produk, 1))
                    {
                        LoadData(); // refresh
                    }
                    else
                    {
                        MessageBox.Show("Gagal menambah stok.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Kurangi")
            {
                if (stokSaatIni <= 0)
                {
                    MessageBox.Show("Stok sudah 0, tidak bisa dikurangi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult result = MessageBox.Show($"Kurangi stok produk '{namaProduk}' sebanyak 1?", "Kurangi Stok", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (produkController.UpdateStok(id_produk, -1))
                    {
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Gagal mengurangi stok.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Tombol navigasi
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
            V_Produk frmProduk = new V_Produk();
            frmProduk.FormClosed += (s, args) => this.Close();
            frmProduk.Show();
            this.Hide();
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
            // Refresh halaman
            LoadData();
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
            Login frmLogin = new Login();
            frmLogin.FormClosed += (s, args) => this.Close();
            frmLogin.Show();
            this.Hide();
        }
    }
}
//using FinalProjek.Controler;
//using FinalProjek.Interface;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Text;
//using System.Windows.Forms;

//namespace FinalProjek.View.Admin_View
//{
//    public partial class V_MonitorStok : Form
//    {
//        public V_MonitorStok()
//        {
//            InitializeComponent();
//        }

//        private void btDashboar_Click(object sender, EventArgs e)
//        {
//            IProduk produkController = new ProdukController(); // buat instance controller
//            AdminDashboardView frmDashboard = new AdminDashboardView(produkController);
//            frmDashboard.FormClosed += (s, args) => this.Close();
//            frmDashboard.Show();
//            this.Hide();
//        }

//        private void btProduk_Click(object sender, EventArgs e)
//        {
//            V_Produk frmProduk = new V_Produk();
//            frmProduk.FormClosed += (s, args) => this.Close();
//            frmProduk.Show();
//            this.Hide();
//        }

//        private void btKategori_Click(object sender, EventArgs e)
//        {
//            V_Kategori frmKategori = new V_Kategori();
//            frmKategori.FormClosed += (s, args) => this.Close();
//            frmKategori.Show();
//            this.Hide();
//        }

//        private void btMonitorStok_Click(object sender, EventArgs e)
//        {

//        }

//        private void btRiwayatTransaksi_Click(object sender, EventArgs e)
//        {
//            V_RiwayatTransaksi frmRiwayatTransaksi = new V_RiwayatTransaksi();
//            frmRiwayatTransaksi.FormClosed += (s, args) => this.Close();
//            frmRiwayatTransaksi.Show();
//            this.Hide();
//        }

//        private void btKelolaAkunUser_Click(object sender, EventArgs e)
//        {
//            V_KelolaAkunUserr frmKelolaAkunUser = new V_KelolaAkunUserr();
//            frmKelolaAkunUser.FormClosed += (s, args) => this.Close();
//            frmKelolaAkunUser.Show();
//            this.Hide();
//        }

//        private void btLogout_Click(object sender, EventArgs e)
//        {
//            Login frmLogin = new Login();
//            frmLogin.FormClosed += (s, args) => this.Close();
//            frmLogin.Show();
//            this.Hide();
//        }
//    }
//}
