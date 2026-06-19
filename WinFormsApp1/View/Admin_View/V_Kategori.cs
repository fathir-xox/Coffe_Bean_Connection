using FinalProjek.Controler;
using FinalProjek.Interface;
using FinalProjek.Model;

namespace FinalProjek.View.Admin_View
{
    public partial class V_Kategori : Form
    {
        private IKategori kategoriController;
        private FlowLayoutPanel flowPanel;
        private Dictionary<int, int> cacheJumlahProduk = new Dictionary<int, int>();

        public V_Kategori()
        {
            InitializeComponent();
            kategoriController = new KategoriController();

            SetupFlowLayoutPanel();

            this.Load += V_Kategori_Load;
            btRefresh.Click += btRefresh_Click;
            btTambahKategori.Click += btTambahKategori_Click;
        }

        private void SetupFlowLayoutPanel()
        {
            panel2.Visible = false;
            panel2.Enabled = false;

            flowPanel = new FlowLayoutPanel();
            flowPanel.Location = new Point(330, 250);
            flowPanel.Size = new Size(1350, 680);
            flowPanel.AutoScroll = true;
            flowPanel.BackColor = Color.Transparent;
            flowPanel.FlowDirection = FlowDirection.LeftToRight;
            flowPanel.WrapContents = true;
            flowPanel.Padding = new Padding(10);

            panel1.Controls.Add(flowPanel);
            flowPanel.BringToFront();
        }

        private void V_Kategori_Load(object sender, EventArgs e)
        {
            LoadKategori();
        }

        public void LoadKategori()
        {
            flowPanel.Controls.Clear();
            this.Cursor = Cursors.WaitCursor;

            List<Kategori> listKategori = kategoriController.GetActiveKategori();

            flowPanel.SuspendLayout();

            foreach (Kategori kategori in listKategori)
            {
                Panel card = CreateKategoriCard(kategori);
                flowPanel.Controls.Add(card);
            }

            flowPanel.ResumeLayout();
            this.Cursor = Cursors.Default;
        }

        private Panel CreateKategoriCard(Kategori kategori)
        {
            Panel card = new Panel();
            card.Size = new Size(380, 190);
            card.Margin = new Padding(10, 10, 10, 10);
            card.BackgroundImage = Properties.Resources.CardKategori;
            card.BackgroundImageLayout = ImageLayout.Zoom;
            card.Tag = kategori.id_kategori;

            Label lblNama = new Label();
            lblNama.Text = kategori.nama_kategori;
            lblNama.Font = new Font("Times New Roman", 14, FontStyle.Bold);
            lblNama.ForeColor = Color.FromArgb(100, 60, 20);
            lblNama.Location = new Point(20, 15);
            lblNama.Size = new Size(220, 30);
            lblNama.BackColor = Color.Transparent;

            Label lblJumlah = new Label();
            int jumlahProduk = GetJumlahProdukByKategori(kategori.id_kategori);
            lblJumlah.Text = $"{jumlahProduk} Produk";
            lblJumlah.Font = new Font("Times New Roman", 11);
            lblJumlah.ForeColor = Color.FromArgb(100, 60, 20);
            lblJumlah.Location = new Point(20, 50);
            lblJumlah.Size = new Size(150, 25);
            lblJumlah.BackColor = Color.Transparent;

            Label lblDeskripsi = new Label();
            string deskripsiText = string.IsNullOrEmpty(kategori.deskripsi) ? "" : kategori.deskripsi;
            lblDeskripsi.Text = deskripsiText;
            lblDeskripsi.Font = new Font("Times New Roman", 9);
            lblDeskripsi.ForeColor = Color.FromArgb(100, 60, 20);
            lblDeskripsi.Location = new Point(20, 130);
            lblDeskripsi.Size = new Size(220, 45);
            lblDeskripsi.BackColor = Color.Transparent;
            lblDeskripsi.AutoSize = false;

            Button btnEdit = new Button();
            btnEdit.Text = "Edit";
            btnEdit.Font = new Font("Times New Roman", 10, FontStyle.Regular);
            btnEdit.BackColor = Color.Wheat;
            btnEdit.Size = new Size(85, 35);
            btnEdit.Location = new Point(275, 15);
            btnEdit.Click += (sender, e) => EditKategori(kategori);

            Button btnHapus = new Button();
            btnHapus.Text = "Hapus";
            btnHapus.Font = new Font("Times New Roman", 10, FontStyle.Regular);
            btnHapus.BackColor = Color.Red;
            btnHapus.ForeColor = Color.White;
            btnHapus.Size = new Size(85, 35);
            btnHapus.Location = new Point(275, 55);
            btnHapus.Click += (sender, e) => HapusKategori(kategori.id_kategori);

            card.Controls.Add(lblNama);
            card.Controls.Add(lblJumlah);
            card.Controls.Add(lblDeskripsi);
            card.Controls.Add(btnEdit);
            card.Controls.Add(btnHapus);

            return card;
        }

        private int GetJumlahProdukByKategori(int idKategori)
        {
            if (cacheJumlahProduk.ContainsKey(idKategori))
            {
                return cacheJumlahProduk[idKategori];
            }

            int jumlah = 0;
            try
            {
                using (var conn = new Npgsql.NpgsqlConnection(new Database.DbContext().connStr))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM produk WHERE id_kategori = @id AND isactive = true";
                    using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idKategori);
                        jumlah = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                cacheJumlahProduk[idKategori] = jumlah;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return jumlah;
        }

        private void EditKategori(Kategori kategori)
        {
            string newNama = ShowInputDialog("Edit Kategori", "Masukkan nama kategori baru:", kategori.nama_kategori);

            if (!string.IsNullOrEmpty(newNama) && newNama != kategori.nama_kategori)
            {
                string newDeskripsi = ShowInputDialog("Edit Kategori", "Masukkan deskripsi baru:", kategori.deskripsi ?? "");

                kategori.nama_kategori = newNama;
                kategori.deskripsi = newDeskripsi;

                bool success = kategoriController.UpdateKategori(kategori);
                if (success)
                {
                    cacheJumlahProduk.Clear();
                    MessageBox.Show("Kategori berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKategori();
                }
            }
        }

        private void HapusKategori(int idKategori)
        {
            DialogResult confirm = MessageBox.Show("Yakin ingin menghapus kategori ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                bool success = kategoriController.DeleteKategori(idKategori);
                if (success)
                {
                    cacheJumlahProduk.Clear();
                    MessageBox.Show("Kategori berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKategori();
                }
            }
        }

        private string ShowInputDialog(string title, string prompt, string defaultValue = "")
        {
            Form dialog = new Form();
            dialog.Text = title;
            dialog.Size = new Size(400, 180);
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
            dialog.MaximizeBox = false;
            dialog.MinimizeBox = false;

            Label lblPrompt = new Label();
            lblPrompt.Text = prompt;
            lblPrompt.Location = new Point(20, 20);
            lblPrompt.Size = new Size(350, 25);

            TextBox txtInput = new TextBox();
            txtInput.Text = defaultValue;
            txtInput.Location = new Point(20, 50);
            txtInput.Size = new Size(350, 25);

            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.Location = new Point(200, 90);
            btnOK.Size = new Size(80, 30);
            btnOK.DialogResult = DialogResult.OK;

            Button btnCancel = new Button();
            btnCancel.Text = "Batal";
            btnCancel.Location = new Point(290, 90);
            btnCancel.Size = new Size(80, 30);
            btnCancel.DialogResult = DialogResult.Cancel;

            dialog.Controls.Add(lblPrompt);
            dialog.Controls.Add(txtInput);
            dialog.Controls.Add(btnOK);
            dialog.Controls.Add(btnCancel);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return txtInput.Text;
            }
            return "";
        }


        private void btTambahKategori_Click(object sender, EventArgs e)
        {
            using (V_TambahKategori formTambah = new V_TambahKategori())
            {
                DialogResult result = formTambah.ShowDialog();
                if (result == DialogResult.OK)
                {
                    cacheJumlahProduk.Clear();
                    LoadKategori();
                }
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            cacheJumlahProduk.Clear();
            LoadKategori();
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
            LoadKategori();
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
            Login frmLogin = new Login();
            frmLogin.FormClosed += (s, args) => this.Close();
            frmLogin.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void btEdit_Click(object sender, EventArgs e)
        {

        }
    }
}