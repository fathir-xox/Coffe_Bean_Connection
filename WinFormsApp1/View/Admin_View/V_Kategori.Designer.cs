namespace FinalProjek.View.Admin_View
{
    partial class V_Kategori
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panel1 = new Panel();
            btLogout = new Button();
            btRefresh = new Button();
            btTambahKategori = new Button();
            btRiwayatTransaksi = new Button();
            btMonitorStok = new Button();
            btKategori = new Button();
            btProduk = new Button();
            btKelolaAkunUser = new Button();
            btDashboar = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            btHapus = new Button();
            btEdit = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.VKategori;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(btLogout);
            panel1.Controls.Add(btRefresh);
            panel1.Controls.Add(btTambahKategori);
            panel1.Controls.Add(btRiwayatTransaksi);
            panel1.Controls.Add(btMonitorStok);
            panel1.Controls.Add(btKategori);
            panel1.Controls.Add(btProduk);
            panel1.Controls.Add(btKelolaAkunUser);
            panel1.Controls.Add(btDashboar);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 1080);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btLogout
            // 
            btLogout.BackColor = Color.Red;
            btLogout.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btLogout.ForeColor = Color.White;
            btLogout.Location = new Point(36, 912);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(224, 41);
            btLogout.TabIndex = 20;
            btLogout.Text = "Logout";
            btLogout.UseVisualStyleBackColor = false;
            btLogout.Click += btLogout_Click;
            // 
            // btRefresh
            // 
            btRefresh.BackColor = Color.OldLace;
            btRefresh.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            btRefresh.ForeColor = Color.FromArgb(100, 60, 20);
            btRefresh.Location = new Point(657, 167);
            btRefresh.Name = "btRefresh";
            btRefresh.Size = new Size(101, 41);
            btRefresh.TabIndex = 6;
            btRefresh.Text = "Refresh";
            btRefresh.UseVisualStyleBackColor = false;
            btRefresh.Click += btRefresh_Click;
            // 
            // btTambahKategori
            // 
            btTambahKategori.BackColor = Color.OldLace;
            btTambahKategori.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            btTambahKategori.ForeColor = Color.FromArgb(100, 60, 20);
            btTambahKategori.Location = new Point(433, 167);
            btTambahKategori.Name = "btTambahKategori";
            btTambahKategori.Size = new Size(164, 41);
            btTambahKategori.TabIndex = 7;
            btTambahKategori.Text = "Tambah Kategori";
            btTambahKategori.UseVisualStyleBackColor = false;
            btTambahKategori.Click += btTambahKategori_Click;
            // 
            // btRiwayatTransaksi
            // 
            btRiwayatTransaksi.BackColor = Color.OldLace;
            btRiwayatTransaksi.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btRiwayatTransaksi.ForeColor = Color.FromArgb(100, 60, 20);
            btRiwayatTransaksi.Location = new Point(77, 633);
            btRiwayatTransaksi.Name = "btRiwayatTransaksi";
            btRiwayatTransaksi.Size = new Size(224, 41);
            btRiwayatTransaksi.TabIndex = 15;
            btRiwayatTransaksi.Text = "Riwayat Transaksi";
            btRiwayatTransaksi.UseVisualStyleBackColor = false;
            btRiwayatTransaksi.Click += btRiwayatTransaksi_Click;
            // 
            // btMonitorStok
            // 
            btMonitorStok.BackColor = Color.OldLace;
            btMonitorStok.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btMonitorStok.ForeColor = Color.FromArgb(100, 60, 20);
            btMonitorStok.Location = new Point(77, 509);
            btMonitorStok.Name = "btMonitorStok";
            btMonitorStok.Size = new Size(224, 41);
            btMonitorStok.TabIndex = 14;
            btMonitorStok.Text = "Monitor Stok";
            btMonitorStok.UseVisualStyleBackColor = false;
            btMonitorStok.Click += btMonitorStok_Click;
            // 
            // btKategori
            // 
            btKategori.BackColor = Color.OldLace;
            btKategori.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btKategori.ForeColor = Color.FromArgb(100, 60, 20);
            btKategori.Location = new Point(77, 426);
            btKategori.Name = "btKategori";
            btKategori.Size = new Size(224, 41);
            btKategori.TabIndex = 13;
            btKategori.Text = "Kategori";
            btKategori.UseVisualStyleBackColor = false;
            btKategori.Click += btKategori_Click;
            // 
            // btProduk
            // 
            btProduk.BackColor = Color.OldLace;
            btProduk.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btProduk.ForeColor = Color.FromArgb(100, 60, 20);
            btProduk.Location = new Point(77, 343);
            btProduk.Name = "btProduk";
            btProduk.Size = new Size(224, 41);
            btProduk.TabIndex = 12;
            btProduk.Text = "Produk";
            btProduk.UseVisualStyleBackColor = false;
            btProduk.Click += btProduk_Click;
            // 
            // btKelolaAkunUser
            // 
            btKelolaAkunUser.BackColor = Color.OldLace;
            btKelolaAkunUser.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btKelolaAkunUser.ForeColor = Color.FromArgb(100, 60, 20);
            btKelolaAkunUser.Location = new Point(77, 757);
            btKelolaAkunUser.Name = "btKelolaAkunUser";
            btKelolaAkunUser.Size = new Size(224, 41);
            btKelolaAkunUser.TabIndex = 11;
            btKelolaAkunUser.Text = "Kelola Akun User";
            btKelolaAkunUser.UseVisualStyleBackColor = false;
            btKelolaAkunUser.Click += btKelolaAkunUser_Click;
            // 
            // btDashboar
            // 
            btDashboar.BackColor = Color.OldLace;
            btDashboar.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btDashboar.ForeColor = Color.FromArgb(100, 60, 20);
            btDashboar.Location = new Point(77, 219);
            btDashboar.Name = "btDashboar";
            btDashboar.Size = new Size(224, 41);
            btDashboar.TabIndex = 10;
            btDashboar.Text = "Dashboard";
            btDashboar.UseVisualStyleBackColor = false;
            btDashboar.Click += btDashboar_Click;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(372, 242);
            panel2.Name = "panel2";
            panel2.Size = new Size(1200, 650);
            panel2.TabIndex = 21;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.CardKategori;
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Controls.Add(btHapus);
            panel3.Controls.Add(btEdit);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(398, 178);
            panel3.TabIndex = 0;
            panel3.Tag = "template";
            // 
            // btHapus
            // 
            btHapus.BackColor = Color.Red;
            btHapus.Font = new Font("Times New Roman", 9F);
            btHapus.ForeColor = Color.White;
            btHapus.Location = new Point(274, 78);
            btHapus.Name = "btHapus";
            btHapus.Size = new Size(88, 36);
            btHapus.TabIndex = 9;
            btHapus.Text = "Hapus";
            btHapus.UseVisualStyleBackColor = false;
            // 
            // btEdit
            // 
            btEdit.BackColor = Color.Wheat;
            btEdit.Font = new Font("Times New Roman", 9F);
            btEdit.ForeColor = Color.Black;
            btEdit.Location = new Point(274, 26);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(88, 36);
            btEdit.TabIndex = 8;
            btEdit.Text = "Edit";
            btEdit.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F);
            label3.ForeColor = Color.FromArgb(100, 60, 20);
            label3.Location = new Point(32, 140);
            label3.Name = "label3";
            label3.Size = new Size(309, 20);
            label3.TabIndex = 10;
            label3.Text = "Kopi dalam bentuk biji utuh (whole bean)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11F);
            label2.ForeColor = Color.FromArgb(100, 60, 20);
            label2.Location = new Point(32, 57);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 1;
            label2.Text = "4 Produk";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(100, 60, 20);
            label1.Location = new Point(32, 21);
            label1.Name = "label1";
            label1.Size = new Size(143, 36);
            label1.TabIndex = 0;
            label1.Text = "Biji Kopi";
            // 
            // V_Kategori
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panel1);
            Name = "V_Kategori";
            Text = "Kategori";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        private Panel panel1;
        private Button btRiwayatTransaksi;
        private Button btMonitorStok;
        private Button btKategori;
        private Button btProduk;
        private Button btKelolaAkunUser;
        private Button btDashboar;
        private Button btLogout;
        private Button btRefresh;
        private Button btTambahKategori;
        private Panel panel2;
        private Panel panel3;
        private Button btHapus;
        private Button btEdit;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}