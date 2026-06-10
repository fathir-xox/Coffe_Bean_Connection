namespace FinalProjek.View.Admin_View
{
    partial class V_Produk
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel8 = new Panel();
            btHapus = new Button();
            Stok = new Label();
            btEdit = new Button();
            NamaProduk = new Label();
            labelStok = new Label();
            HargaProduk = new Label();
            pictureBox1 = new PictureBox();
            btRefresh = new Button();
            btTambahProduk = new Button();
            btRiwayatTransaksi = new Button();
            btMonitorStok = new Button();
            btKategori = new Button();
            btProduk = new Button();
            btKelolaAkunUser = new Button();
            btDashboar = new Button();
            btLogout = new Button();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Vproduk;
            panel1.Controls.Add(btLogout);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(btRefresh);
            panel1.Controls.Add(btTambahProduk);
            panel1.Controls.Add(btRiwayatTransaksi);
            panel1.Controls.Add(btMonitorStok);
            panel1.Controls.Add(btKategori);
            panel1.Controls.Add(btProduk);
            panel1.Controls.Add(btKelolaAkunUser);
            panel1.Controls.Add(btDashboar);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1897, 1023);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(panel8);
            flowLayoutPanel1.Location = new Point(356, 236);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1520, 776);
            flowLayoutPanel1.TabIndex = 18;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Transparent;
            panel8.BackgroundImage = Properties.Resources.Card;
            panel8.BackgroundImageLayout = ImageLayout.Zoom;
            panel8.Controls.Add(btHapus);
            panel8.Controls.Add(Stok);
            panel8.Controls.Add(btEdit);
            panel8.Controls.Add(NamaProduk);
            panel8.Controls.Add(labelStok);
            panel8.Controls.Add(HargaProduk);
            panel8.Controls.Add(pictureBox1);
            panel8.Location = new Point(3, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(213, 305);
            panel8.TabIndex = 6;
            // 
            // btHapus
            // 
            btHapus.BackColor = Color.Red;
            btHapus.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btHapus.ForeColor = Color.White;
            btHapus.Location = new Point(103, 246);
            btHapus.Name = "btHapus";
            btHapus.Size = new Size(76, 37);
            btHapus.TabIndex = 8;
            btHapus.Text = "Hapus";
            btHapus.UseVisualStyleBackColor = false;
            // 
            // Stok
            // 
            Stok.AutoSize = true;
            Stok.BackColor = Color.Transparent;
            Stok.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Stok.ForeColor = Color.FromArgb(100, 60, 20);
            Stok.Location = new Point(107, 202);
            Stok.Name = "Stok";
            Stok.Size = new Size(34, 25);
            Stok.TabIndex = 5;
            Stok.Text = "20";
            // 
            // btEdit
            // 
            btEdit.BackColor = Color.Wheat;
            btEdit.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btEdit.ForeColor = Color.Black;
            btEdit.Location = new Point(36, 246);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(59, 37);
            btEdit.TabIndex = 7;
            btEdit.Text = "Edit";
            btEdit.UseVisualStyleBackColor = false;
            // 
            // NamaProduk
            // 
            NamaProduk.AutoSize = true;
            NamaProduk.BackColor = Color.Transparent;
            NamaProduk.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NamaProduk.ForeColor = Color.Black;
            NamaProduk.Location = new Point(8, 136);
            NamaProduk.Name = "NamaProduk";
            NamaProduk.Size = new Size(197, 26);
            NamaProduk.TabIndex = 2;
            NamaProduk.Text = "Biji Kopi Arabika";
            NamaProduk.Click += NamaProduk_Click;
            // 
            // labelStok
            // 
            labelStok.AutoSize = true;
            labelStok.BackColor = Color.Transparent;
            labelStok.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStok.ForeColor = Color.FromArgb(100, 60, 20);
            labelStok.Location = new Point(53, 202);
            labelStok.Name = "labelStok";
            labelStok.Size = new Size(58, 25);
            labelStok.TabIndex = 2;
            labelStok.Text = "Stok:";
            // 
            // HargaProduk
            // 
            HargaProduk.AutoSize = true;
            HargaProduk.BackColor = Color.Transparent;
            HargaProduk.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HargaProduk.ForeColor = Color.FromArgb(100, 60, 20);
            HargaProduk.Location = new Point(47, 167);
            HargaProduk.Name = "HargaProduk";
            HargaProduk.Size = new Size(112, 25);
            HargaProduk.TabIndex = 4;
            HargaProduk.Text = "Rp. 55.000";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.ArabikaC;
            pictureBox1.Location = new Point(32, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 122);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btRefresh
            // 
            btRefresh.BackColor = Color.OldLace;
            btRefresh.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btRefresh.ForeColor = Color.FromArgb(100, 60, 20);
            btRefresh.Location = new Point(639, 167);
            btRefresh.Name = "btRefresh";
            btRefresh.Size = new Size(101, 41);
            btRefresh.TabIndex = 16;
            btRefresh.Text = "Refresh";
            btRefresh.UseVisualStyleBackColor = false;
            // 
            // btTambahProduk
            // 
            btTambahProduk.BackColor = Color.OldLace;
            btTambahProduk.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTambahProduk.ForeColor = Color.FromArgb(100, 60, 20);
            btTambahProduk.Location = new Point(415, 167);
            btTambahProduk.Name = "btTambahProduk";
            btTambahProduk.Size = new Size(164, 41);
            btTambahProduk.TabIndex = 17;
            btTambahProduk.Text = "Tambah Produk";
            btTambahProduk.UseVisualStyleBackColor = false;
            btTambahProduk.Click += btTambahProduk_Click;
            // 
            // btRiwayatTransaksi
            // 
            btRiwayatTransaksi.BackColor = Color.OldLace;
            btRiwayatTransaksi.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btRiwayatTransaksi.ForeColor = Color.FromArgb(100, 60, 20);
            btRiwayatTransaksi.Location = new Point(77, 634);
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
            btMonitorStok.Location = new Point(77, 510);
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
            btKategori.Location = new Point(77, 427);
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
            btProduk.Location = new Point(77, 344);
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
            btKelolaAkunUser.Location = new Point(77, 758);
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
            btDashboar.Location = new Point(77, 220);
            btDashboar.Name = "btDashboar";
            btDashboar.Size = new Size(224, 41);
            btDashboar.TabIndex = 10;
            btDashboar.Text = "Dashboard";
            btDashboar.UseVisualStyleBackColor = false;
            btDashboar.Click += btDashboar_Click;
            // 
            // btLogout
            // 
            btLogout.BackColor = Color.Red;
            btLogout.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogout.ForeColor = Color.White;
            btLogout.Location = new Point(38, 912);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(224, 41);
            btLogout.TabIndex = 19;
            btLogout.Text = "Logout";
            btLogout.UseVisualStyleBackColor = false;
            btLogout.Click += btLogout_Click;
            // 
            // V_Produk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panel1);
            Name = "V_Produk";
            Text = "V_Produk";
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button btRefresh;
        private Button btTambahProduk;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel8;
        private Button btHapus;
        private Label Stok;
        private Button btEdit;
        private Label NamaProduk;
        private Label labelStok;
        private Label HargaProduk;
        private PictureBox pictureBox1;
        private Button btLogout;
    }
}