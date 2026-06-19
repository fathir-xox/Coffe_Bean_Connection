using FinalProjek.Controler;
using FinalProjek.Interface;
using FinalProjek.Helper;
using FinalProjek.Model;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProjek.View.Admin_View
{
    public partial class V_RiwayatTransaksi : Form
    {
        private TransaksiController transaksiController;

        public V_RiwayatTransaksi()
        {
            InitializeComponent();
            transaksiController = new TransaksiController();
            this.Load += V_RiwayatTransaksi_Load;
        }

        private void V_RiwayatTransaksi_Load(object sender, EventArgs e)
        {
            LoadAllRiwayat();
        }

        private void LoadAllRiwayat()
        {
            try
            {
                DataTable dt = transaksiController.GetAllRiwayatTransaksi();
                if (dt == null || dt.Rows.Count == 0)
                {
                    dgvRiwayat.DataSource = null;
                    MessageBox.Show("Belum ada data transaksi.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                SetupDesainTabel();
                dgvRiwayat.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat riwayat transaksi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDesainTabel()
        {
            dgvRiwayat.AutoGenerateColumns = true;
            dgvRiwayat.BorderStyle = BorderStyle.None;
            dgvRiwayat.BackgroundColor = Color.White;
            dgvRiwayat.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRiwayat.RowHeadersVisible = false;
            dgvRiwayat.AllowUserToAddRows = false;
            dgvRiwayat.ReadOnly = true;
            dgvRiwayat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRiwayat.RowTemplate.Height = 45;
            dgvRiwayat.ColumnHeadersHeight = 40;
            dgvRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            V_MonitorStok frmMonitorStok = new V_MonitorStok();
            frmMonitorStok.FormClosed += (s, args) => this.Close();
            frmMonitorStok.Show();
            this.Hide();
        }

        private void btRiwayatTransaksi_Click(object sender, EventArgs e)
        {
            LoadAllRiwayat(); 
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