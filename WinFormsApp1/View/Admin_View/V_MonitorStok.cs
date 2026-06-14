using FinalProjek.Controler;
using FinalProjek.Model;
using System;
using System.Drawing;
using System.Windows.Forms;
using FinalProjek.Interface;

namespace FinalProjek.View.Admin_View
{
    public partial class V_MonitorStok : Form
    {
        private ProdukController produkController;

        public V_MonitorStok()
        {
            InitializeComponent();
            produkController = new ProdukController();
            SetupDesainTabel();
            LoadData();
            dataGridView1.CellClick += DataGridView1_CellClick;
            dataGridView1.CellPainting += DataGridView1_CellPainting;
        }

        private void SetupDesainTabel()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            // Kolom PRODUK
            DataGridViewTextBoxColumn colProduk = new DataGridViewTextBoxColumn
            {
                Name = "Produk",
                HeaderText = "PRODUK",
                DataPropertyName = "nama_produk",
                Width = 300
            };
            dataGridView1.Columns.Add(colProduk);

            // Kolom STOK
            DataGridViewTextBoxColumn colStok = new DataGridViewTextBoxColumn
            {
                Name = "Stok",
                HeaderText = "STOK",
                DataPropertyName = "stok",
                Width = 100
            };
            dataGridView1.Columns.Add(colStok);

            // Kolom tombol RESTOK
            DataGridViewButtonColumn colRestok = new DataGridViewButtonColumn
            {
                Name = "Restok",
                HeaderText = "AKSI",
                Text = "Restok",
                UseColumnTextForButtonValue = true,
                Width = 80
            };
            dataGridView1.Columns.Add(colRestok);

            // Kolom tombol KURANGI
            DataGridViewButtonColumn colKurangi = new DataGridViewButtonColumn
            {
                Name = "Kurangi",
                HeaderText = "",
                Text = "Kurangi",
                UseColumnTextForButtonValue = true,
                Width = 80
            };
            dataGridView1.Columns.Add(colKurangi);

            // Pengaturan tampilan
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadData()
        {
            try
            {
                var produkList = produkController.GetAllProduk();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = produkList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data produk: " + ex.Message);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (columnName != "Restok" && columnName != "Kurangi") return;

            int id_produk = (int)dataGridView1.Rows[e.RowIndex].Cells["id_produk"].Value;
            string namaProduk = dataGridView1.Rows[e.RowIndex].Cells["nama_produk"].Value.ToString();
            int stokSaatIni = (int)dataGridView1.Rows[e.RowIndex].Cells["stok"].Value;

            if (columnName == "Restok")
            {
                if (MessageBox.Show($"Tambah stok produk '{namaProduk}' sebanyak 1?", "Restok", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (produkController.UpdateStok(id_produk, 1)) LoadData();
                    else MessageBox.Show("Gagal menambah stok.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (columnName == "Kurangi")
            {
                if (stokSaatIni <= 0)
                {
                    MessageBox.Show("Stok sudah habis, tidak bisa dikurangi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show($"Kurangi stok produk '{namaProduk}' sebanyak 1?", "Kurangi Stok", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (produkController.UpdateStok(id_produk, -1)) LoadData();
                    else MessageBox.Show("Gagal mengurangi stok.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Restok")
                {
                    e.CellStyle.BackColor = Color.LightGreen;
                    e.CellStyle.ForeColor = Color.DarkGreen;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    e.CellStyle.SelectionBackColor = Color.Green;
                    e.CellStyle.SelectionForeColor = Color.White;
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Kurangi")
                {
                    e.CellStyle.BackColor = Color.LightCoral;
                    e.CellStyle.ForeColor = Color.DarkRed;
                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    e.CellStyle.SelectionBackColor = Color.Red;
                    e.CellStyle.SelectionForeColor = Color.White;
                }
            }
        }

        // Navigasi (pastikan nama event handler sesuai dengan di desainer)
        private void btDashboar_Click(object sender, EventArgs e)
        {
            IProduk pc = new ProdukController();
            AdminDashboardView frm = new AdminDashboardView(pc);
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
            this.Hide();
        }

        private void btProduk_Click(object sender, EventArgs e)
        {
            V_Produk frm = new V_Produk();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
            this.Hide();
        }

        private void btKategori_Click(object sender, EventArgs e)
        {
            V_Kategori frm = new V_Kategori();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
            this.Hide();
        }

        private void btMonitorStok_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btRiwayatTransaksi_Click(object sender, EventArgs e)
        {
            V_RiwayatTransaksi frm = new V_RiwayatTransaksi();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
            this.Hide();
        }

        private void btKelolaAkunUser_Click(object sender, EventArgs e)
        {
            V_KelolaAkunUserr frm = new V_KelolaAkunUserr();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
            this.Hide();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
            this.Hide();
        }
    }
}