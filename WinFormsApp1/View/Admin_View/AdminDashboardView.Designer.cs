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
            btKelolaAkunUser = new Button();
            btDashboar = new Button();
            btRefresh = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel8 = new Panel();
            btHapus = new Button();
            Stok = new Label();
            btEdit = new Button();
            NamaProduk = new Label();
            labelStok = new Label();
            HargaProduk = new Label();
            pictureBox1 = new PictureBox();
            Label_totalProduk = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Label_totalPenjualan = new Label();
            Label_totalPenghasilan = new Label();
            btTambahProduk = new Button();
            panel6 = new Panel();
            flowLayoutPanel1.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // btKelolaAkunUser
            // 
            btKelolaAkunUser.BackColor = Color.OldLace;
            btKelolaAkunUser.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btKelolaAkunUser.ForeColor = Color.FromArgb(100, 60, 20);
            btKelolaAkunUser.Location = new Point(75, 758);
            btKelolaAkunUser.Name = "btKelolaAkunUser";
            btKelolaAkunUser.Size = new Size(224, 41);
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
            btDashboar.Location = new Point(75, 220);
            btDashboar.Name = "btDashboar";
            btDashboar.Size = new Size(224, 41);
            btDashboar.TabIndex = 2;
            btDashboar.Text = "Beranda";
            btDashboar.UseVisualStyleBackColor = false;
            btDashboar.Click += btDashboar_Click;
            // 
            // btRefresh
            // 
            btRefresh.BackColor = Color.OldLace;
            btRefresh.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btRefresh.ForeColor = Color.FromArgb(100, 60, 20);
            btRefresh.Location = new Point(1773, 167);
            btRefresh.Name = "btRefresh";
            btRefresh.Size = new Size(101, 41);
            btRefresh.TabIndex = 5;
            btRefresh.Text = "Refresh";
            btRefresh.UseVisualStyleBackColor = false;
            btRefresh.Click += btRefreshData_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(panel8);
            flowLayoutPanel1.Location = new Point(366, 287);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1520, 725);
            flowLayoutPanel1.TabIndex = 2;
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
            panel8.Size = new Size(175, 248);
            panel8.TabIndex = 6;
            panel8.Paint += panel8_Paint;
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
            // Label_totalProduk
            // 
            Label_totalProduk.AutoSize = true;
            Label_totalProduk.BackColor = Color.Transparent;
            Label_totalProduk.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_totalProduk.ForeColor = Color.FromArgb(100, 60, 20);
            Label_totalProduk.Location = new Point(389, 214);
            Label_totalProduk.Name = "Label_totalProduk";
            Label_totalProduk.Size = new Size(36, 26);
            Label_totalProduk.TabIndex = 1;
            Label_totalProduk.Text = "20";
            Label_totalProduk.Click += Label_totalProduk_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(389, 176);
            label4.Name = "label4";
            label4.Size = new Size(136, 27);
            label4.TabIndex = 0;
            label4.Text = "Total Produk";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(724, 176);
            label5.Name = "label5";
            label5.Size = new Size(161, 27);
            label5.TabIndex = 2;
            label5.Text = "Total Penjualan";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(1053, 176);
            label6.Name = "label6";
            label6.Size = new Size(181, 27);
            label6.TabIndex = 3;
            label6.Text = "Total Penghasilan";
            // 
            // Label_totalPenjualan
            // 
            Label_totalPenjualan.AutoSize = true;
            Label_totalPenjualan.BackColor = Color.Transparent;
            Label_totalPenjualan.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_totalPenjualan.ForeColor = Color.FromArgb(100, 60, 20);
            Label_totalPenjualan.Location = new Point(724, 214);
            Label_totalPenjualan.Name = "Label_totalPenjualan";
            Label_totalPenjualan.Size = new Size(36, 26);
            Label_totalPenjualan.TabIndex = 2;
            Label_totalPenjualan.Text = "55";
            // 
            // Label_totalPenghasilan
            // 
            Label_totalPenghasilan.AutoSize = true;
            Label_totalPenghasilan.BackColor = Color.Transparent;
            Label_totalPenghasilan.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_totalPenghasilan.ForeColor = Color.FromArgb(100, 60, 20);
            Label_totalPenghasilan.Location = new Point(1053, 214);
            Label_totalPenghasilan.Name = "Label_totalPenghasilan";
            Label_totalPenghasilan.Size = new Size(150, 26);
            Label_totalPenghasilan.TabIndex = 3;
            Label_totalPenghasilan.Text = "Rp. 1.450.000";
            // 
            // btTambahProduk
            // 
            btTambahProduk.BackColor = Color.OldLace;
            btTambahProduk.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTambahProduk.ForeColor = Color.FromArgb(100, 60, 20);
            btTambahProduk.Location = new Point(1549, 167);
            btTambahProduk.Name = "btTambahProduk";
            btTambahProduk.Size = new Size(164, 41);
            btTambahProduk.TabIndex = 5;
            btTambahProduk.Text = "Tambah Produk";
            btTambahProduk.UseVisualStyleBackColor = false;
            btTambahProduk.Click += btTambahProduk_Click;
            // 
            // panel6
            // 
            panel6.BackgroundImage = Properties.Resources.Dashboard;
            panel6.Controls.Add(btRefresh);
            panel6.Controls.Add(Label_totalPenghasilan);
            panel6.Controls.Add(btTambahProduk);
            panel6.Controls.Add(Label_totalPenjualan);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(Label_totalProduk);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(btKelolaAkunUser);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(btDashboar);
            panel6.Controls.Add(flowLayoutPanel1);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1898, 1024);
            panel6.TabIndex = 6;
            panel6.Paint += panel6_Paint;
            // 
            // AdminDashboardView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panel6);
            Name = "AdminDashboardView";
            Text = "AdminDashboardView";
            flowLayoutPanel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btDashboar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label Label_totalProduk;
        private Label label4;
        private Label Label_totalPenjualan;
        private Label label5;
        private Label Label_totalPenghasilan;
        private Label label6;
        private Panel panel8;
        private PictureBox pictureBox1;
        private Label NamaProduk;
        private Label HargaProduk;
        private Label labelStok;
        private Label Stok;
        private Button btEdit;
        private Button btHapus;
        private Button btTambahProduk;
        private Button btRefresh;
        private Button btKelolaAkunUser;
        private Panel panel6;
    }
}