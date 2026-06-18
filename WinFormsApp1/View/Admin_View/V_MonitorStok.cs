using FinalProjek.Controler;
<<<<<<< HEAD
using FinalProjek.Model;
=======
using FinalProjek.Interface;
using FinalProjek.Model; // WAJIB: Untuk memanggil class Produk
>>>>>>> origin/controler
using System;
using System.Drawing;
using System.Windows.Forms;
using FinalProjek.Interface;

namespace FinalProjek.View.Admin_View
{
    public partial class V_MonitorStok : Form
    {
<<<<<<< HEAD
=======
        // 1. Deklarasikan Controller
>>>>>>> origin/controler
        private ProdukController produkController;

        public V_MonitorStok()
        {
            InitializeComponent();
<<<<<<< HEAD
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
=======

            // 2. Inisialisasi controller dan jalankan pemuatan data
            produkController = new ProdukController();
            LoadDataStok();
        }

        // ==============================================================
        // BAGIAN 1: LOGIKA MONITOR STOK (TAMPILAN & UPDATE)
        // ==============================================================
        public void LoadDataStok()
        {
            try
            {
                // Bersihkan memori dari baris yang lama (PENTING: Pastikan Anda punya FlowLayoutPanel bernama flpMonitorStok)
                foreach (Control control in flpMonitorStok.Controls) control.Dispose();
                flpMonitorStok.Controls.Clear();

                flpMonitorStok.SuspendLayout();

                List<Produk> produks = produkController.GetAllProduk();

                foreach (Produk produk in produks)
                {
                    Panel rowPanel = CreateStokRow(produk);
                    flpMonitorStok.Controls.Add(rowPanel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data stok: " + ex.Message, "Sistem Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                flpMonitorStok.ResumeLayout();
            }
        }

        private Panel CreateStokRow(Produk produk)
        {
            // 1. Buat Baris Background
            Panel row = new Panel
            {
                Size = new Size(750, 50), // Sesuaikan dengan lebar layar monitor stok Anda
                Margin = new Padding(0, 0, 0, 10),
                BackColor = Color.OldLace // Warna krem sesuai tema
            };

            // 2. Nama Produk
            Label lblNama = new Label
            {
                Text = produk.nama_produk,
                Location = new Point(20, 15),
                Size = new Size(250, 25),
                Font = new Font("Segoe UI", 11, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleLeft
            };

            // 3. Stok Saat Ini (Warna Merah)
            Label lblStok = new Label
            {
                Text = produk.stok + " kg",
                Location = new Point(280, 15),
                Size = new Size(100, 25),
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.Crimson,
                TextAlign = ContentAlignment.MiddleLeft
            };

            // 4. Tombol Restok (Orange)
            Button btnRestok = new Button
            {
                Text = "Restok",
                Location = new Point(500, 10),
                Size = new Size(80, 30),
                BackColor = Color.Chocolate,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnRestok.FlatAppearance.BorderSize = 0;
            btnRestok.Click += (sender, e) => ProsesUpdateStok(produk, "tambah");

            // 5. Tombol Kurangi (Merah)
            Button btnKurangi = new Button
            {
                Text = "Kurangi",
                Location = new Point(590, 10),
                Size = new Size(80, 30),
                BackColor = Color.Red,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnKurangi.FlatAppearance.BorderSize = 0;
            btnKurangi.Click += (sender, e) => ProsesUpdateStok(produk, "kurang");

            row.Controls.Add(lblNama);
            row.Controls.Add(lblStok);
            row.Controls.Add(btnRestok);
            row.Controls.Add(btnKurangi);

            return row;
        }

        private void ProsesUpdateStok(Produk produk, string aksi)
        {
            // Popup Otomatis untuk Input Angka
            Form prompt = new Form()
            {
                Width = 350,
                Height = 180,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = aksi == "tambah" ? "Restok: " + produk.nama_produk : "Kurangi: " + produk.nama_produk,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false
            };

            Label textLabel = new Label() { Left = 20, Top = 20, Width = 300, Text = "Masukkan jumlah yang ingin di" + aksi + ":" };
            NumericUpDown inputAngka = new NumericUpDown() { Left = 20, Top = 50, Width = 290, Maximum = 10000, Minimum = 1 };
            Button confirmation = new Button() { Text = "Simpan", Left = 230, Width = 80, Top = 90, DialogResult = DialogResult.OK, BackColor = Color.Chocolate, ForeColor = Color.White, FlatStyle = FlatStyle.Flat };

            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputAngka);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            if (prompt.ShowDialog() == DialogResult.OK)
            {
                int nilaiInput = (int)inputAngka.Value;

                if (aksi == "kurang")
                {
                    if (produk.stok - nilaiInput < 0)
                    {
                        MessageBox.Show("Stok tidak bisa kurang dari 0!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    nilaiInput = nilaiInput * -1; // Ubah jadi minus agar stok berkurang
                }

                // Panggil fungsi UpdateStok di Controller
                bool sukses = produkController.UpdateStok(produk.id_produk, nilaiInput);

                if (sukses)
                {
                    MessageBox.Show("Stok berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataStok(); // Refresh tampilan stok otomatis
                }
            }

            prompt.Dispose();
        }


        // ==============================================================
        // BAGIAN 2: LOGIKA NAVIGASI SIDEBAR
        // ==============================================================
        private void btDashboar_Click(object sender, EventArgs e)
        {
            IProduk produkControllerInterface = new ProdukController();
            AdminDashboardView frmDashboard = new AdminDashboardView(produkControllerInterface);
            frmDashboard.FormClosed += (s, args) => this.Close();
            frmDashboard.Show();
>>>>>>> origin/controler
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
<<<<<<< HEAD
            LoadData();
=======
            // Kosongkan saja. Karena ini adalah halaman Monitor Stok, tombol tidak perlu bereaksi jika diklik lagi.
>>>>>>> origin/controler
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