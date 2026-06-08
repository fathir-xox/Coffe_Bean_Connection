namespace FinalProjek.View.Admin_View
{
    partial class AdminDashboardView
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
            btKelolaAkunUser = new Button();
            btDashboar = new Button();
            panel3 = new Panel();
            label1 = new Label();
            btRefreshData = new Button();
            panel2 = new Panel();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel8 = new Panel();
            btHapus = new Button();
            Stok = new Label();
            btEdit = new Button();
            NamaProduk = new Label();
            labelStok = new Label();
            HargaProduk = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            Label_totalProduk = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Label_totalPenjualan = new Label();
            Label_totalPenghasilan = new Label();
            panel9 = new Panel();
            panel5 = new Panel();
            btTambahProduk = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel9.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(100, 60, 20);
            panel1.Controls.Add(btKelolaAkunUser);
            panel1.Controls.Add(btDashboar);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 664);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // btKelolaAkunUser
            // 
            btKelolaAkunUser.BackColor = Color.OldLace;
            btKelolaAkunUser.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btKelolaAkunUser.ForeColor = Color.FromArgb(100, 60, 20);
            btKelolaAkunUser.Location = new Point(16, 595);
            btKelolaAkunUser.Name = "btKelolaAkunUser";
            btKelolaAkunUser.Size = new Size(156, 41);
            btKelolaAkunUser.TabIndex = 5;
            btKelolaAkunUser.Text = "Kelola Akun User";
            btKelolaAkunUser.UseVisualStyleBackColor = false;
            btKelolaAkunUser.Click += btKelolaAkunUser_Click;
            // 
            // btDashboar
            // 
            btDashboar.BackColor = Color.OldLace;
            btDashboar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDashboar.ForeColor = Color.FromArgb(100, 60, 20);
            btDashboar.Location = new Point(16, 99);
            btDashboar.Name = "btDashboar";
            btDashboar.Size = new Size(156, 41);
            btDashboar.TabIndex = 2;
            btDashboar.Text = "Beranda";
            btDashboar.UseVisualStyleBackColor = false;
            btDashboar.Click += btDashboar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PapayaWhip;
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(192, 75);
            panel3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(100, 60, 20);
            label1.Location = new Point(19, 25);
            label1.Name = "label1";
            label1.Size = new Size(155, 26);
            label1.TabIndex = 2;
            label1.Text = "CoffeeBean.id";
            label1.Click += label1_Click;
            // 
            // btRefreshData
            // 
            btRefreshData.BackColor = Color.OldLace;
            btRefreshData.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btRefreshData.ForeColor = Color.FromArgb(100, 60, 20);
            btRefreshData.Location = new Point(1041, 129);
            btRefreshData.Name = "btRefreshData";
            btRefreshData.Size = new Size(156, 41);
            btRefreshData.TabIndex = 5;
            btRefreshData.Text = "Refresh Data";
            btRefreshData.UseVisualStyleBackColor = false;
            btRefreshData.Click += btRefreshData_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Linen;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(192, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1066, 75);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(100, 60, 20);
            label2.Location = new Point(5, 22);
            label2.Name = "label2";
            label2.Size = new Size(234, 32);
            label2.TabIndex = 3;
            label2.Text = "Dashboard Admin";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(panel8);
            flowLayoutPanel1.Location = new Point(202, 174);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1044, 479);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Transparent;
            panel8.BackgroundImage = Properties.Resources.CardView;
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
            panel8.Size = new Size(175, 248);
            panel8.TabIndex = 6;
            // 
            // btHapus
            // 
            btHapus.BackColor = Color.Red;
            btHapus.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btHapus.ForeColor = Color.White;
            btHapus.Location = new Point(87, 200);
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
            Stok.Font = new Font("Times New Roman", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Stok.ForeColor = Color.FromArgb(100, 60, 20);
            Stok.Location = new Point(92, 163);
            Stok.Name = "Stok";
            Stok.Size = new Size(25, 19);
            Stok.TabIndex = 5;
            Stok.Text = "20";
            // 
            // btEdit
            // 
            btEdit.BackColor = Color.Wheat;
            btEdit.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btEdit.ForeColor = Color.Black;
            btEdit.Location = new Point(20, 200);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(59, 37);
            btEdit.TabIndex = 7;
            btEdit.Text = "Edit";
            btEdit.UseVisualStyleBackColor = false;
            btEdit.Click += button3_Click;
            // 
            // NamaProduk
            // 
            NamaProduk.AutoSize = true;
            NamaProduk.BackColor = Color.Transparent;
            NamaProduk.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NamaProduk.ForeColor = Color.Black;
            NamaProduk.Location = new Point(49, 114);
            NamaProduk.Name = "NamaProduk";
            NamaProduk.Size = new Size(78, 23);
            NamaProduk.TabIndex = 2;
            NamaProduk.Text = "Arabika";
            NamaProduk.Click += label8_Click;
            // 
            // labelStok
            // 
            labelStok.AutoSize = true;
            labelStok.BackColor = Color.Transparent;
            labelStok.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStok.ForeColor = Color.FromArgb(100, 60, 20);
            labelStok.Location = new Point(53, 162);
            labelStok.Name = "labelStok";
            labelStok.Size = new Size(46, 20);
            labelStok.TabIndex = 2;
            labelStok.Text = "Stok:";
            labelStok.Click += label10_Click;
            // 
            // HargaProduk
            // 
            HargaProduk.AutoSize = true;
            HargaProduk.BackColor = Color.Transparent;
            HargaProduk.Font = new Font("Times New Roman", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HargaProduk.ForeColor = Color.FromArgb(100, 60, 20);
            HargaProduk.Location = new Point(47, 140);
            HargaProduk.Name = "HargaProduk";
            HargaProduk.Size = new Size(81, 19);
            HargaProduk.TabIndex = 4;
            HargaProduk.Text = "Rp. 55.000";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.ArabikaC;
            pictureBox1.Location = new Point(32, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 103);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(Label_totalProduk);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(205, 85);
            panel4.Name = "panel4";
            panel4.Size = new Size(231, 77);
            panel4.TabIndex = 3;
            // 
            // Label_totalProduk
            // 
            Label_totalProduk.AutoSize = true;
            Label_totalProduk.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_totalProduk.ForeColor = Color.FromArgb(100, 60, 20);
            Label_totalProduk.Location = new Point(6, 40);
            Label_totalProduk.Name = "Label_totalProduk";
            Label_totalProduk.Size = new Size(36, 26);
            Label_totalProduk.TabIndex = 1;
            Label_totalProduk.Text = "20";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(5, 5);
            label4.Name = "label4";
            label4.Size = new Size(136, 27);
            label4.TabIndex = 0;
            label4.Text = "Total Produk";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 6);
            label5.Name = "label5";
            label5.Size = new Size(161, 27);
            label5.TabIndex = 2;
            label5.Text = "Total Penjualan";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 6);
            label6.Name = "label6";
            label6.Size = new Size(181, 27);
            label6.TabIndex = 3;
            label6.Text = "Total Penghasilan";
            // 
            // Label_totalPenjualan
            // 
            Label_totalPenjualan.AutoSize = true;
            Label_totalPenjualan.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_totalPenjualan.ForeColor = Color.FromArgb(100, 60, 20);
            Label_totalPenjualan.Location = new Point(5, 41);
            Label_totalPenjualan.Name = "Label_totalPenjualan";
            Label_totalPenjualan.Size = new Size(36, 26);
            Label_totalPenjualan.TabIndex = 2;
            Label_totalPenjualan.Text = "55";
            // 
            // Label_totalPenghasilan
            // 
            Label_totalPenghasilan.AutoSize = true;
            Label_totalPenghasilan.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_totalPenghasilan.ForeColor = Color.FromArgb(100, 60, 20);
            Label_totalPenghasilan.Location = new Point(4, 40);
            Label_totalPenghasilan.Name = "Label_totalPenghasilan";
            Label_totalPenghasilan.Size = new Size(150, 26);
            Label_totalPenghasilan.TabIndex = 3;
            Label_totalPenghasilan.Text = "Rp. 1.450.000";
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Controls.Add(Label_totalPenjualan);
            panel9.Controls.Add(label5);
            panel9.Location = new Point(473, 85);
            panel9.Name = "panel9";
            panel9.Size = new Size(231, 77);
            panel9.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(Label_totalPenghasilan);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(744, 85);
            panel5.Name = "panel5";
            panel5.Size = new Size(231, 77);
            panel5.TabIndex = 5;
            // 
            // btTambahProduk
            // 
            btTambahProduk.BackColor = Color.OldLace;
            btTambahProduk.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTambahProduk.ForeColor = Color.FromArgb(100, 60, 20);
            btTambahProduk.Location = new Point(1041, 83);
            btTambahProduk.Name = "btTambahProduk";
            btTambahProduk.Size = new Size(156, 41);
            btTambahProduk.TabIndex = 5;
            btTambahProduk.Text = "Tambah Produk";
            btTambahProduk.UseVisualStyleBackColor = false;
            btTambahProduk.Click += btTambahProduk_Click;
            // 
            // AdminDashboardView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 664);
            Controls.Add(btRefreshData);
            Controls.Add(panel5);
            Controls.Add(btTambahProduk);
            Controls.Add(panel9);
            Controls.Add(panel4);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminDashboardView";
            Text = "AdminDashboardView";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Button btDashboar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel4;
        private Label Label_totalProduk;
        private Label label4;
        private Label Label_totalPenjualan;
        private Label label5;
        private Label Label_totalPenghasilan;
        private Label label6;
        private Panel panel8;
        private Panel panel9;
        private Panel panel5;
        private PictureBox pictureBox1;
        private Label NamaProduk;
        private Label HargaProduk;
        private Label labelStok;
        private Label Stok;
        private Button btEdit;
        private Button btHapus;
        private Button btTambahProduk;
        private Button btRefreshData;
        private Button btKelolaAkunUser;
    }
}