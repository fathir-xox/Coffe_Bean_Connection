namespace FinalProjek.View.Admin_View
{
    partial class V_MonitorStok
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
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            flpMonitorStok = new FlowLayoutPanel();
            pmonitorstok = new Panel();
            btKurangi = new Button();
            lbNamaProduk = new Label();
            btRestok = new Button();
            btLogout = new Button();
            btRiwayatTransaksi = new Button();
            btMonitorStok = new Button();
            btKategori = new Button();
            btProduk = new Button();
            btKelolaAkunUser = new Button();
            btDashboar = new Button();
            lbStok = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flpMonitorStok.SuspendLayout();
            pmonitorstok.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.VMonitorProduk;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(flpMonitorStok);
            panel1.Controls.Add(btLogout);
            panel1.Controls.Add(btRiwayatTransaksi);
            panel1.Controls.Add(btMonitorStok);
            panel1.Controls.Add(btKategori);
            panel1.Controls.Add(btProduk);
            panel1.Controls.Add(btKelolaAkunUser);
            panel1.Controls.Add(btDashboar);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1898, 1027);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.CardMonitorStok__1_;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(603, 194);
            panel2.Name = "panel2";
            panel2.Size = new Size(1055, 67);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(100, 60, 20);
            label2.Location = new Point(534, 19);
            label2.Name = "label2";
            label2.Size = new Size(68, 32);
            label2.TabIndex = 23;
            label2.Text = "Stok";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(100, 60, 20);
            label1.Location = new Point(139, 18);
            label1.Name = "label1";
            label1.Size = new Size(104, 32);
            label1.TabIndex = 22;
            label1.Text = "Produk";
            // 
            // flpMonitorStok
            // 
            flpMonitorStok.AllowDrop = true;
            flpMonitorStok.AutoScroll = true;
            flpMonitorStok.BackColor = Color.Transparent;
            flpMonitorStok.Controls.Add(pmonitorstok);
            flpMonitorStok.Location = new Point(602, 267);
            flpMonitorStok.Name = "flpMonitorStok";
            flpMonitorStok.Size = new Size(1056, 745);
            flpMonitorStok.TabIndex = 17;
            // 
            // pmonitorstok
            // 
            pmonitorstok.BackgroundImage = Properties.Resources.CardMonitorStokdalam;
            pmonitorstok.BackgroundImageLayout = ImageLayout.Zoom;
            pmonitorstok.Controls.Add(lbStok);
            pmonitorstok.Controls.Add(btKurangi);
            pmonitorstok.Controls.Add(lbNamaProduk);
            pmonitorstok.Controls.Add(btRestok);
            pmonitorstok.Location = new Point(3, 3);
            pmonitorstok.Name = "pmonitorstok";
            pmonitorstok.Size = new Size(1053, 92);
            pmonitorstok.TabIndex = 1;
            // 
            // btKurangi
            // 
            btKurangi.BackColor = Color.Red;
            btKurangi.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btKurangi.ForeColor = Color.White;
            btKurangi.Location = new Point(911, 25);
            btKurangi.Name = "btKurangi";
            btKurangi.Size = new Size(125, 43);
            btKurangi.TabIndex = 22;
            btKurangi.Text = "Kurangi";
            btKurangi.UseVisualStyleBackColor = false;
            btKurangi.Click += btKurangi_Click;
            // 
            // lbNamaProduk
            // 
            lbNamaProduk.AutoSize = true;
            lbNamaProduk.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNamaProduk.ForeColor = Color.Black;
            lbNamaProduk.Location = new Point(24, 30);
            lbNamaProduk.Name = "lbNamaProduk";
            lbNamaProduk.Size = new Size(454, 32);
            lbNamaProduk.TabIndex = 20;
            lbNamaProduk.Text = "NamaProduk                                        ";
            lbNamaProduk.Click += lbNamaProduk_Click;
            // 
            // btRestok
            // 
            btRestok.BackColor = Color.DarkOrange;
            btRestok.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btRestok.ForeColor = Color.White;
            btRestok.Location = new Point(780, 25);
            btRestok.Name = "btRestok";
            btRestok.Size = new Size(125, 43);
            btRestok.TabIndex = 19;
            btRestok.Text = "Restok";
            btRestok.UseVisualStyleBackColor = false;
            btRestok.Click += btRestok_Click;
            // 
            // btLogout
            // 
            btLogout.BackColor = Color.Red;
            btLogout.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btLogout.ForeColor = Color.White;
            btLogout.Location = new Point(38, 912);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(224, 41);
            btLogout.TabIndex = 16;
            btLogout.Text = "Logout";
            btLogout.UseVisualStyleBackColor = false;
            btLogout.Click += btLogout_Click;
            // 
            // btRiwayatTransaksi
            // 
            btRiwayatTransaksi.BackColor = Color.OldLace;
            btRiwayatTransaksi.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btRiwayatTransaksi.ForeColor = Color.FromArgb(100, 60, 20);
            btRiwayatTransaksi.Location = new Point(75, 633);
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
            btMonitorStok.Location = new Point(75, 509);
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
            btKategori.Location = new Point(75, 426);
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
            btProduk.Location = new Point(75, 343);
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
            btKelolaAkunUser.Location = new Point(75, 757);
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
            btDashboar.Location = new Point(75, 219);
            btDashboar.Name = "btDashboar";
            btDashboar.Size = new Size(224, 41);
            btDashboar.TabIndex = 10;
            btDashboar.Text = "Dashboard";
            btDashboar.UseVisualStyleBackColor = false;
            btDashboar.Click += btDashboar_Click;
            // 
            // lbStok
            // 
            lbStok.AutoSize = true;
            lbStok.BackColor = Color.Transparent;
            lbStok.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbStok.ForeColor = Color.FromArgb(100, 60, 20);
            lbStok.Location = new Point(535, 29);
            lbStok.Name = "lbStok";
            lbStok.RightToLeft = RightToLeft.Yes;
            lbStok.Size = new Size(49, 32);
            lbStok.TabIndex = 23;
            lbStok.Text = "20 ";
            lbStok.Click += lbStok_Click;
            // 
            // V_MonitorStok
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panel1);
            Name = "V_MonitorStok";
            Text = "Monitor Stok";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flpMonitorStok.ResumeLayout(false);
            pmonitorstok.ResumeLayout(false);
            pmonitorstok.PerformLayout();
            ResumeLayout(false);
        }

        #region Fields
        private Panel panel1;
        private Button btRiwayatTransaksi;
        private Button btMonitorStok;
        private Button btKategori;
        private Button btProduk;
        private Button btKelolaAkunUser;
        private Button btDashboar;
        private Button btLogout;
        private FlowLayoutPanel flpMonitorStok;
        #endregion

        private Panel panel2;
        private Panel pmonitorstok;
        private Label lbNamaProduk;
        private Button btRestok;
        private Label label2;
        private Label label1;
        private Button btKurangi;
        private Label lbStok;
    }
}



//namespace FinalProjek.View.Admin_View
//{
//    partial class V_MonitorStok
//    {
//        private System.ComponentModel.IContainer components = null;

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        private void InitializeComponent()
//        {
//            panel1 = new Panel();
//            btLogout = new Button();
//            btRiwayatTransaksi = new Button();
//            btMonitorStok = new Button();
//            btKategori = new Button();
//            btProduk = new Button();
//            btKelolaAkunUser = new Button();
//            btDashboar = new Button();
//                        flpMonitorStok = new FlowLayoutPanel();
//                        panel1.SuspendLayout();
//                        SuspendLayout();

//            // panel1
//            panel1.BackgroundImage = Properties.Resources.VMonitorProduk;
//                        panel1.Controls.Add(flpMonitorStok);
//                        panel1.Controls.Add(btLogout);
//            panel1.Controls.Add(btRiwayatTransaksi);
//            panel1.Controls.Add(btMonitorStok);
//            panel1.Controls.Add(btKategori);
//            panel1.Controls.Add(btProduk);
//            panel1.Controls.Add(btKelolaAkunUser);
//            panel1.Controls.Add(btDashboar);
//            panel1.Location = new Point(0, 0);
//            panel1.Name = "panel1";
//            panel1.Size = new Size(1898, 1027);
//            panel1.TabIndex = 0;


//            // btLogout
//            btLogout.BackColor = Color.Red;
//            btLogout.Font = new Font("Times New Roman", 12F, FontStyle.Bold);

//            // 
//            // btLogout
//            // 
//            btLogout.BackColor = Color.Red;
//            btLogout.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);

//            btLogout.ForeColor = Color.White;
//            btLogout.Location = new Point(38, 912);
//            btLogout.Name = "btLogout";
//            btLogout.Size = new Size(224, 41);
//            btLogout.TabIndex = 16;
//            btLogout.Text = "Logout";
//            btLogout.UseVisualStyleBackColor = false;
//            btLogout.Click += btLogout_Click;


//            // btRiwayatTransaksi
//            btRiwayatTransaksi.BackColor = Color.OldLace;
//            btRiwayatTransaksi.Font = new Font("Times New Roman", 12F, FontStyle.Bold);

//            // 
//            // btRiwayatTransaksi
//            // 
//            btRiwayatTransaksi.BackColor = Color.OldLace;
//            btRiwayatTransaksi.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);

//            btRiwayatTransaksi.ForeColor = Color.FromArgb(100, 60, 20);
//            btRiwayatTransaksi.Location = new Point(75, 633);
//            btRiwayatTransaksi.Name = "btRiwayatTransaksi";
//            btRiwayatTransaksi.Size = new Size(224, 41);
//            btRiwayatTransaksi.TabIndex = 15;
//            btRiwayatTransaksi.Text = "Riwayat Transaksi";
//            btRiwayatTransaksi.UseVisualStyleBackColor = false;
//            btRiwayatTransaksi.Click += btRiwayatTransaksi_Click;


//            // btMonitorStok
//            btMonitorStok.BackColor = Color.OldLace;
//            btMonitorStok.Font = new Font("Times New Roman", 12F, FontStyle.Bold);

//            // 
//            // btMonitorStok
//            // 
//            btMonitorStok.BackColor = Color.OldLace;
//            btMonitorStok.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);

//            btMonitorStok.ForeColor = Color.FromArgb(100, 60, 20);
//            btMonitorStok.Location = new Point(75, 509);
//            btMonitorStok.Name = "btMonitorStok";
//            btMonitorStok.Size = new Size(224, 41);
//            btMonitorStok.TabIndex = 14;
//            btMonitorStok.Text = "Monitor Stok";
//            btMonitorStok.UseVisualStyleBackColor = false;
//            btMonitorStok.Click += btMonitorStok_Click;


//            // btKategori
//            btKategori.BackColor = Color.OldLace;
//            btKategori.Font = new Font("Times New Roman", 12F, FontStyle.Bold);

//            // 
//            // btKategori
//            // 
//            btKategori.BackColor = Color.OldLace;
//            btKategori.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);

//            btKategori.ForeColor = Color.FromArgb(100, 60, 20);
//            btKategori.Location = new Point(75, 426);
//            btKategori.Name = "btKategori";
//            btKategori.Size = new Size(224, 41);
//            btKategori.TabIndex = 13;
//            btKategori.Text = "Kategori";
//            btKategori.UseVisualStyleBackColor = false;
//            btKategori.Click += btKategori_Click;


//            // btProduk
//            btProduk.BackColor = Color.OldLace;
//            btProduk.Font = new Font("Times New Roman", 12F, FontStyle.Bold);

//            // 
//            // btProduk
//            // 
//            btProduk.BackColor = Color.OldLace;
//            btProduk.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);

//            btProduk.ForeColor = Color.FromArgb(100, 60, 20);
//            btProduk.Location = new Point(75, 343);
//            btProduk.Name = "btProduk";
//            btProduk.Size = new Size(224, 41);
//            btProduk.TabIndex = 12;
//            btProduk.Text = "Produk";
//            btProduk.UseVisualStyleBackColor = false;
//            btProduk.Click += btProduk_Click;


//            // btKelolaAkunUser
//            btKelolaAkunUser.BackColor = Color.OldLace;
//            btKelolaAkunUser.Font = new Font("Times New Roman", 12F, FontStyle.Bold);

//            // 
//            // btKelolaAkunUser
//            // 
//            btKelolaAkunUser.BackColor = Color.OldLace;
//            btKelolaAkunUser.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);

//            btKelolaAkunUser.ForeColor = Color.FromArgb(100, 60, 20);
//            btKelolaAkunUser.Location = new Point(75, 757);
//            btKelolaAkunUser.Name = "btKelolaAkunUser";
//            btKelolaAkunUser.Size = new Size(224, 41);
//            btKelolaAkunUser.TabIndex = 11;
//            btKelolaAkunUser.Text = "Kelola Akun User";
//            btKelolaAkunUser.UseVisualStyleBackColor = false;
//            btKelolaAkunUser.Click += btKelolaAkunUser_Click;

//            btDashboar.BackColor = Color.OldLace;
//            btDashboar.Font = new Font("Times New Roman", 12F, FontStyle.Bold);

//            // 
//            // btDashboar
//            // 
//            btDashboar.BackColor = Color.OldLace;
//            btDashboar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);

//            btDashboar.ForeColor = Color.FromArgb(100, 60, 20);
//            btDashboar.Location = new Point(75, 219);
//            btDashboar.Name = "btDashboar";
//            btDashboar.Size = new Size(224, 41);
//            btDashboar.TabIndex = 10;
//            btDashboar.Text = "Dashboard";
//            btDashboar.UseVisualStyleBackColor = false;
//            btDashboar.Click += btDashboar_Click;


//            // dataGridView1
//            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            dataGridView1.Location = new Point(354, 171);
//            dataGridView1.Name = "dataGridView1";
//            dataGridView1.RowHeadersWidth = 62;
//            dataGridView1.Size = new Size(1519, 841);
//            dataGridView1.TabIndex = 17;

//            // ========== TAMBAHAN: KOLOM TOMBOL RESTOK & KURANGI ==========
//            DataGridViewButtonColumn colRestok = new DataGridViewButtonColumn();
//            colRestok.Name = "Restok";
//            colRestok.HeaderText = "Aksi";
//            colRestok.Text = "Restok";
//            colRestok.UseColumnTextForButtonValue = true;
//            colRestok.Width = 80;
//            dataGridView1.Columns.Add(colRestok);

//            DataGridViewButtonColumn colKurangi = new DataGridViewButtonColumn();
//            colKurangi.Name = "Kurangi";
//            colKurangi.HeaderText = "";
//            colKurangi.Text = "Kurangi";
//            colKurangi.UseColumnTextForButtonValue = true;
//            colKurangi.Width = 80;
//            dataGridView1.Columns.Add(colKurangi);
//            // ==============================================================

//            // 
//            // flpMonitorStok
//            // 
//            flpMonitorStok.AllowDrop = true;
//            flpMonitorStok.AutoScroll = true;
//            flpMonitorStok.BackColor = Color.Transparent;
//            flpMonitorStok.Location = new Point(351, 152);
//            flpMonitorStok.Name = "flpMonitorStok";
//            flpMonitorStok.Size = new Size(1535, 860);
//            flpMonitorStok.TabIndex = 17;
//            // 
//            // V_MonitorStok
//            AutoScaleDimensions = new SizeF(10F, 25F);
//            AutoScaleMode = AutoScaleMode.Font;
//            ClientSize = new Size(1898, 1024);
//            Controls.Add(panel1);
//            Name = "V_MonitorStok";
//            Text = "Monitor Stok";
//            panel1.ResumeLayout(false);
//            ResumeLayout(false);
//        }

//        private Panel panel1;
//        private Button btRiwayatTransaksi;
//        private Button btMonitorStok;
//        private Button btKategori;
//        private Button btProduk;
//        private Button btKelolaAkunUser;
//        private Button btDashboar;
//        private Button btLogout;
//        private FlowLayoutPanel flpMonitorStok;
//    }
//}

////namespace FinalProjek.View.Admin_View
////{
////    partial class V_MonitorStok
////    {
////        /// <summary>
////        /// Required designer variable.
////        /// </summary>
////        private System.ComponentModel.IContainer components = null;

////        /// <summary>
////        /// Clean up any resources being used.
////        /// </summary>
////        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
////        protected override void Dispose(bool disposing)
////        {
////            if (disposing && (components != null))
////            {
////                components.Dispose();
////            }
////            base.Dispose(disposing);
////        }

////        #region Windows Form Designer generated code

////        /// <summary>
////        /// Required method for Designer support - do not modify
////        /// the contents of this method with the code editor.
////        /// </summary>
////        private void InitializeComponent()
////        {
////            panel1 = new Panel();
////            btLogout = new Button();
////            btRiwayatTransaksi = new Button();
////            btMonitorStok = new Button();
////            btKategori = new Button();
////            btProduk = new Button();
////            btKelolaAkunUser = new Button();
////            btDashboar = new Button();
////            dataGridView1 = new DataGridView();
////            panel1.SuspendLayout();
////            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
////            SuspendLayout();
////            // 
////            // panel1
////            // 
////            panel1.BackgroundImage = Properties.Resources.VMonitorProduk;
////            panel1.Controls.Add(dataGridView1);
////            panel1.Controls.Add(btLogout);
////            panel1.Controls.Add(btRiwayatTransaksi);
////            panel1.Controls.Add(btMonitorStok);
////            panel1.Controls.Add(btKategori);
////            panel1.Controls.Add(btProduk);
////            panel1.Controls.Add(btKelolaAkunUser);
////            panel1.Controls.Add(btDashboar);
////            panel1.Location = new Point(0, 0);
////            panel1.Name = "panel1";
////            panel1.Size = new Size(1898, 1027);
////            panel1.TabIndex = 0;
////            // 
////            // btLogout
////            // 
////            btLogout.BackColor = Color.Red;
////            btLogout.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
////            btLogout.ForeColor = Color.White;
////            btLogout.Location = new Point(38, 912);
////            btLogout.Name = "btLogout";
////            btLogout.Size = new Size(224, 41);
////            btLogout.TabIndex = 16;
////            btLogout.Text = "Logout";
////            btLogout.UseVisualStyleBackColor = false;
////            btLogout.Click += btLogout_Click;
////            // 
////            // btRiwayatTransaksi
////            // 
////            btRiwayatTransaksi.BackColor = Color.OldLace;
////            btRiwayatTransaksi.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
////            btRiwayatTransaksi.ForeColor = Color.FromArgb(100, 60, 20);
////            btRiwayatTransaksi.Location = new Point(75, 633);
////            btRiwayatTransaksi.Name = "btRiwayatTransaksi";
////            btRiwayatTransaksi.Size = new Size(224, 41);
////            btRiwayatTransaksi.TabIndex = 15;
////            btRiwayatTransaksi.Text = "Riwayat Transaksi";
////            btRiwayatTransaksi.UseVisualStyleBackColor = false;
////            btRiwayatTransaksi.Click += btRiwayatTransaksi_Click;
////            // 
////            // btMonitorStok
////            // 
////            btMonitorStok.BackColor = Color.OldLace;
////            btMonitorStok.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
////            btMonitorStok.ForeColor = Color.FromArgb(100, 60, 20);
////            btMonitorStok.Location = new Point(75, 509);
////            btMonitorStok.Name = "btMonitorStok";
////            btMonitorStok.Size = new Size(224, 41);
////            btMonitorStok.TabIndex = 14;
////            btMonitorStok.Text = "Monitor Stok";
////            btMonitorStok.UseVisualStyleBackColor = false;
////            btMonitorStok.Click += btMonitorStok_Click;
////            // 
////            // btKategori
////            // 
////            btKategori.BackColor = Color.OldLace;
////            btKategori.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
////            btKategori.ForeColor = Color.FromArgb(100, 60, 20);
////            btKategori.Location = new Point(75, 426);
////            btKategori.Name = "btKategori";
////            btKategori.Size = new Size(224, 41);
////            btKategori.TabIndex = 13;
////            btKategori.Text = "Kategori";
////            btKategori.UseVisualStyleBackColor = false;
////            btKategori.Click += btKategori_Click;
////            // 
////            // btProduk
////            // 
////            btProduk.BackColor = Color.OldLace;
////            btProduk.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
////            btProduk.ForeColor = Color.FromArgb(100, 60, 20);
////            btProduk.Location = new Point(75, 343);
////            btProduk.Name = "btProduk";
////            btProduk.Size = new Size(224, 41);
////            btProduk.TabIndex = 12;
////            btProduk.Text = "Produk";
////            btProduk.UseVisualStyleBackColor = false;
////            btProduk.Click += btProduk_Click;
////            // 
////            // btKelolaAkunUser
////            // 
////            btKelolaAkunUser.BackColor = Color.OldLace;
////            btKelolaAkunUser.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
////            btKelolaAkunUser.ForeColor = Color.FromArgb(100, 60, 20);
////            btKelolaAkunUser.Location = new Point(75, 757);
////            btKelolaAkunUser.Name = "btKelolaAkunUser";
////            btKelolaAkunUser.Size = new Size(224, 41);
////            btKelolaAkunUser.TabIndex = 11;
////            btKelolaAkunUser.Text = "Kelola Akun User";
////            btKelolaAkunUser.UseVisualStyleBackColor = false;
////            btKelolaAkunUser.Click += btKelolaAkunUser_Click;
////            // 
////            // btDashboar
////            // 
////            btDashboar.BackColor = Color.OldLace;
////            btDashboar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
////            btDashboar.ForeColor = Color.FromArgb(100, 60, 20);
////            btDashboar.Location = new Point(75, 219);
////            btDashboar.Name = "btDashboar";
////            btDashboar.Size = new Size(224, 41);
////            btDashboar.TabIndex = 10;
////            btDashboar.Text = "Dashboard";
////            btDashboar.UseVisualStyleBackColor = false;
////            btDashboar.Click += btDashboar_Click;
////            // 
////            // dataGridView1
////            // 
////            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
////            dataGridView1.Location = new Point(354, 171);
////            dataGridView1.Name = "dataGridView1";
////            dataGridView1.RowHeadersWidth = 62;
////            dataGridView1.Size = new Size(1519, 841);
////            dataGridView1.TabIndex = 17;
////            // 
////            // V_MonitorStok
////            // 
////            AutoScaleDimensions = new SizeF(10F, 25F);
////            AutoScaleMode = AutoScaleMode.Font;
////            ClientSize = new Size(1898, 1024);
////            Controls.Add(panel1);
////            Name = "V_MonitorStok";
////            Text = "V_MonitorStok";
////            panel1.ResumeLayout(false);
////            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
////            ResumeLayout(false);
////        }

////        #endregion

////        private Panel panel1;
////        private Button btRiwayatTransaksi;
////        private Button btMonitorStok;
////        private Button btKategori;
////        private Button btProduk;
////        private Button btKelolaAkunUser;
////        private Button btDashboar;
////        private Button btLogout;
////        private DataGridView dataGridView1;
////    }
////}