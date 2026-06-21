using FinalProjek.Controler;
using FinalProjek.Helper;
using FinalProjek.Model; 

namespace FinalProjek.View.Kasir_View
{
    public partial class V_RiwayatSaya : Form
    {
        private TransaksiController transaksiController;

        public V_RiwayatSaya()
        {
            InitializeComponent();
            transaksiController = new TransaksiController();
        }

        private void V_RiwayatSaya_Load(object sender, EventArgs e)
        {
            if (APPSession.CurrentUser != null)
            {
                int idKasirAktif = APPSession.CurrentUser.id_user;
                LoadStatistikCard(idKasirAktif);
                LoadTabelRiwayat(idKasirAktif);
            }
            else
            {
                MessageBox.Show("Sesi login tidak ditemukan. Silakan login kembali.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadStatistikCard(int idKasir)
        {
            try
            {
                var statistik = transaksiController.GetStatistikRiwayat(idKasir);
                lblTotalTrx.Text = statistik.jumlahTransaksi.ToString();
                lblTotalItem.Text = statistik.totalItem.ToString();
                lblOmzet.Text = $"Rp {statistik.omzet:N0}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat statistik: " + ex.Message);
            }
        }

        private void LoadTabelRiwayat(int idUser)
        {
            try
            {
                SetupDesainTabel();
                List<Transaksi> listRiwayat = transaksiController.GetRiwayatLengkapByUser(idUser);
                dgvRiwayat.Rows.Clear();

                foreach (var trx in listRiwayat)
                {
                    dgvRiwayat.Rows.Add(
                        $"#{trx.id_transaksi:D4}",
                        trx.tanggal.ToString("dd MMM yyyy, HH.mm"),
                        trx.total_item.ToString(),
                        $"Rp {trx.total_harga:N0}",
                        char.ToUpper(trx.metode_bayar[0]) + trx.metode_bayar.Substring(1)
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat tabel riwayat: " + ex.Message);
            }
        }

        private void SetupDesainTabel()
        {
            if (dgvRiwayat.Columns.Count > 0) return; 

            dgvRiwayat.AutoGenerateColumns = false;
            dgvRiwayat.Columns.Add("ColNoTrx", "NO. TRX");
            dgvRiwayat.Columns.Add("ColTanggal", "TANGGAL");
            dgvRiwayat.Columns.Add("ColItem", "ITEM");
            dgvRiwayat.Columns.Add("ColTotal", "TOTAL");
            dgvRiwayat.Columns.Add("ColMetode", "METODE");

            dgvRiwayat.BorderStyle = BorderStyle.None;
            dgvRiwayat.BackgroundColor = Color.White;
            dgvRiwayat.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRiwayat.RowHeadersVisible = false;
            dgvRiwayat.AllowUserToAddRows = false;
            dgvRiwayat.ReadOnly = true;
            dgvRiwayat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRiwayat.RowTemplate.Height = 45;
            dgvRiwayat.ColumnHeadersHeight = 40;
        }
        private void btTransaksi_Click(object sender, EventArgs e)
        {
            KasirDashboardView frmKasir = new KasirDashboardView();
            frmKasir.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void V_RiwayatSaya_Load_1(object sender, EventArgs e) { }

        private void btLogout_Click(object sender, EventArgs e)
        {
            APPSession.Logout();
            Login frmLogin = new Login();
            frmLogin.Show();
            this.Close();
        }

        private void btDaftarProduk_Click(object sender, EventArgs e)
        {
            Form formProduk = Application.OpenForms["V_DaftarProduk"];

            if (formProduk != null)
            {
                formProduk.Show();
            }
            else
            {
                V_DaftarProduk produkBaru = new V_DaftarProduk();
                produkBaru.Show();
            }

            this.Hide();
        }
    }
}