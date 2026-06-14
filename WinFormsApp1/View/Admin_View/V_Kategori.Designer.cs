namespace FinalProjek.View.Admin_View
{
    partial class V_Kategori
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btRefresh = new Button();
            btLogout = new Button();
            btTambahKategori = new Button();
            btRiwayatTransaksi = new Button();
            btMonitorStok = new Button();
            btKategori = new Button();
            btProduk = new Button();
            btKelolaAkunUser = new Button();
            btDashboar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.VKategori;
            panel1.Controls.Add(btRefresh);
            panel1.Controls.Add(btLogout);
            panel1.Controls.Add(btTambahKategori);
            panel1.Controls.Add(btRiwayatTransaksi);
            panel1.Controls.Add(btMonitorStok);
            panel1.Controls.Add(btKategori);
            panel1.Controls.Add(btProduk);
            panel1.Controls.Add(btKelolaAkunUser);
            panel1.Controls.Add(btDashboar);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1899, 1023);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btRefresh
            // 
            btRefresh.BackColor = Color.OldLace;
            btRefresh.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btRefresh.ForeColor = Color.FromArgb(100, 60, 20);
            btRefresh.Location = new Point(657, 167);
            btRefresh.Name = "btRefresh";
            btRefresh.Size = new Size(101, 41);
            btRefresh.TabIndex = 6;
            btRefresh.Text = "Refresh";
            btRefresh.UseVisualStyleBackColor = false;
            // 
            // btLogout
            // 
            btLogout.BackColor = Color.Red;
            btLogout.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogout.ForeColor = Color.White;
            btLogout.Location = new Point(36, 912);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(224, 41);
            btLogout.TabIndex = 20;
            btLogout.Text = "Logout";
            btLogout.UseVisualStyleBackColor = false;
            btLogout.Click += btLogout_Click;
            // 
            // btTambahKategori
            // 
            btTambahKategori.BackColor = Color.OldLace;
            btTambahKategori.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btRiwayatTransaksi.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btMonitorStok.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btKategori.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btProduk.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btKelolaAkunUser.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btDashboar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDashboar.ForeColor = Color.FromArgb(100, 60, 20);
            btDashboar.Location = new Point(77, 219);
            btDashboar.Name = "btDashboar";
            btDashboar.Size = new Size(224, 41);
            btDashboar.TabIndex = 10;
            btDashboar.Text = "Dashboard";
            btDashboar.UseVisualStyleBackColor = false;
            btDashboar.Click += btDashboar_Click;
            // 
            // V_Kategori
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panel1);
            Name = "V_Kategori";
            Text = "V_Kategori";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

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
    }
}