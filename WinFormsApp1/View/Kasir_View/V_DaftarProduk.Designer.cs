namespace FinalProjek.View.Kasir_View
{
    partial class V_DaftarProduk
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
            Stok = new Label();
            NamaProduk = new Label();
            HargaProduk = new Label();
            pictureBox1 = new PictureBox();
            btLogout = new Button();
            btDaftarProduk = new Button();
            btRiwayatTransaksi = new Button();
            btTransaksi = new Button();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.VDaftarProduk;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(btLogout);
            panel1.Controls.Add(btDaftarProduk);
            panel1.Controls.Add(btRiwayatTransaksi);
            panel1.Controls.Add(btTransaksi);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1901, 1027);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(panel8);
            flowLayoutPanel1.Location = new Point(348, 150);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1538, 863);
            flowLayoutPanel1.TabIndex = 16;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Transparent;
            panel8.BackgroundImage = Properties.Resources.Card;
            panel8.BackgroundImageLayout = ImageLayout.Zoom;
            panel8.Controls.Add(Stok);
            panel8.Controls.Add(NamaProduk);
            panel8.Controls.Add(HargaProduk);
            panel8.Controls.Add(pictureBox1);
            panel8.Location = new Point(3, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(213, 305);
            panel8.TabIndex = 6;
            // 
            // Stok
            // 
            Stok.AutoSize = true;
            Stok.BackColor = Color.Transparent;
            Stok.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Stok.ForeColor = Color.FromArgb(100, 60, 20);
            Stok.Location = new Point(47, 258);
            Stok.Name = "Stok";
            Stok.RightToLeft = RightToLeft.Yes;
            Stok.Size = new Size(101, 25);
            Stok.TabIndex = 5;
            Stok.Text = "Stok : 20 ";
            // 
            // NamaProduk
            // 
            NamaProduk.AutoSize = true;
            NamaProduk.BackColor = Color.Transparent;
            NamaProduk.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NamaProduk.ForeColor = Color.Black;
            NamaProduk.Location = new Point(8, 179);
            NamaProduk.Name = "NamaProduk";
            NamaProduk.Size = new Size(197, 26);
            NamaProduk.TabIndex = 2;
            NamaProduk.Text = "Biji Kopi Arabika";
            // 
            // HargaProduk
            // 
            HargaProduk.AutoSize = true;
            HargaProduk.BackColor = Color.Transparent;
            HargaProduk.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HargaProduk.ForeColor = Color.FromArgb(100, 60, 20);
            HargaProduk.Location = new Point(47, 219);
            HargaProduk.Name = "HargaProduk";
            HargaProduk.Size = new Size(112, 25);
            HargaProduk.TabIndex = 4;
            HargaProduk.Text = "Rp. 55.000";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.ArabikaC;
            pictureBox1.Location = new Point(14, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 147);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btLogout
            // 
            btLogout.BackColor = Color.Red;
            btLogout.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogout.ForeColor = Color.White;
            btLogout.Location = new Point(37, 912);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(224, 41);
            btLogout.TabIndex = 15;
            btLogout.Text = "Logout";
            btLogout.UseVisualStyleBackColor = false;
            btLogout.Click += btLogout_Click;
            // 
            // btDaftarProduk
            // 
            btDaftarProduk.BackColor = Color.OldLace;
            btDaftarProduk.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDaftarProduk.ForeColor = Color.FromArgb(100, 60, 20);
            btDaftarProduk.Location = new Point(77, 428);
            btDaftarProduk.Name = "btDaftarProduk";
            btDaftarProduk.Size = new Size(224, 41);
            btDaftarProduk.TabIndex = 14;
            btDaftarProduk.Text = "Daftar Produk";
            btDaftarProduk.UseVisualStyleBackColor = false;
            // 
            // btRiwayatTransaksi
            // 
            btRiwayatTransaksi.BackColor = Color.OldLace;
            btRiwayatTransaksi.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btRiwayatTransaksi.ForeColor = Color.FromArgb(100, 60, 20);
            btRiwayatTransaksi.Location = new Point(77, 304);
            btRiwayatTransaksi.Name = "btRiwayatTransaksi";
            btRiwayatTransaksi.Size = new Size(224, 41);
            btRiwayatTransaksi.TabIndex = 13;
            btRiwayatTransaksi.Text = "Riwayat Transaksi";
            btRiwayatTransaksi.UseVisualStyleBackColor = false;
            btRiwayatTransaksi.Click += btRiwayatTransaksi_Click;
            // 
            // btTransaksi
            // 
            btTransaksi.BackColor = Color.OldLace;
            btTransaksi.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTransaksi.ForeColor = Color.FromArgb(100, 60, 20);
            btTransaksi.Location = new Point(77, 220);
            btTransaksi.Name = "btTransaksi";
            btTransaksi.Size = new Size(224, 41);
            btTransaksi.TabIndex = 12;
            btTransaksi.Text = "Transaksi";
            btTransaksi.UseVisualStyleBackColor = false;
            btTransaksi.Click += btTransaksi_Click;
            // 
            // V_DaftarProduk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panel1);
            Name = "V_DaftarProduk";
            Text = "V_DaftarProduk";
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btLogout;
        private Button btDaftarProduk;
        private Button btRiwayatTransaksi;
        private Button btTransaksi;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel8;
        private Label Stok;
        private Label NamaProduk;
        private Label HargaProduk;
        private PictureBox pictureBox1;
    }
}