namespace FinalProjek.View.Admin_View
{
    partial class V_KelolaAkunUserr
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
            flpKelolaUser = new FlowLayoutPanel();
            pmonitorstok = new Panel();
            lbstatusUser = new Label();
            lbRoleUser = new Label();
            lbNamaLengkapUser = new Label();
            btHapusUser = new Button();
            lbUsername = new Label();
            btEditUser = new Button();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btRefresh = new Button();
            btTambahUser = new Button();
            btLogout = new Button();
            btRiwayatTransaksi = new Button();
            btMonitorStok = new Button();
            btKategori = new Button();
            btProduk = new Button();
            btKelolaAkunUser = new Button();
            btDashboar = new Button();
            panel1.SuspendLayout();
            flpKelolaUser.SuspendLayout();
            pmonitorstok.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Vkelolauser;
            panel1.Controls.Add(flpKelolaUser);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btLogout);
            panel1.Controls.Add(btRiwayatTransaksi);
            panel1.Controls.Add(btMonitorStok);
            panel1.Controls.Add(btKategori);
            panel1.Controls.Add(btProduk);
            panel1.Controls.Add(btKelolaAkunUser);
            panel1.Controls.Add(btDashboar);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1898, 1025);
            panel1.TabIndex = 0;
            // 
            // flpKelolaUser
            // 
            flpKelolaUser.AllowDrop = true;
            flpKelolaUser.AutoScroll = true;
            flpKelolaUser.BackColor = Color.Transparent;
            flpKelolaUser.Controls.Add(pmonitorstok);
            flpKelolaUser.Location = new Point(373, 321);
            flpKelolaUser.Name = "flpKelolaUser";
            flpKelolaUser.Size = new Size(1498, 745);
            flpKelolaUser.TabIndex = 19;
            // 
            // pmonitorstok
            // 
            pmonitorstok.BackgroundImage = Properties.Resources.CardMonitorStokdalam;
            pmonitorstok.BackgroundImageLayout = ImageLayout.Stretch;
            pmonitorstok.Controls.Add(lbstatusUser);
            pmonitorstok.Controls.Add(lbRoleUser);
            pmonitorstok.Controls.Add(lbNamaLengkapUser);
            pmonitorstok.Controls.Add(btHapusUser);
            pmonitorstok.Controls.Add(lbUsername);
            pmonitorstok.Controls.Add(btEditUser);
            pmonitorstok.Location = new Point(3, 3);
            pmonitorstok.Name = "pmonitorstok";
            pmonitorstok.Size = new Size(1495, 92);
            pmonitorstok.TabIndex = 1;
            // 
            // lbstatusUser
            // 
            lbstatusUser.AutoSize = true;
            lbstatusUser.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbstatusUser.ForeColor = Color.Black;
            lbstatusUser.Location = new Point(988, 28);
            lbstatusUser.Name = "lbstatusUser";
            lbstatusUser.Size = new Size(144, 32);
            lbstatusUser.TabIndex = 25;
            lbstatusUser.Text = "StatusUser";
            lbstatusUser.Click += lbstatusUser_Click;
            // 
            // lbRoleUser
            // 
            lbRoleUser.AutoSize = true;
            lbRoleUser.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRoleUser.ForeColor = Color.Black;
            lbRoleUser.Location = new Point(728, 30);
            lbRoleUser.Name = "lbRoleUser";
            lbRoleUser.Size = new Size(143, 32);
            lbRoleUser.TabIndex = 24;
            lbRoleUser.Text = "RoleUser   ";
            lbRoleUser.Click += lbRoleUser_Click;
            // 
            // lbNamaLengkapUser
            // 
            lbNamaLengkapUser.AutoSize = true;
            lbNamaLengkapUser.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNamaLengkapUser.ForeColor = Color.Black;
            lbNamaLengkapUser.Location = new Point(280, 29);
            lbNamaLengkapUser.Name = "lbNamaLengkapUser";
            lbNamaLengkapUser.Size = new Size(335, 32);
            lbNamaLengkapUser.TabIndex = 23;
            lbNamaLengkapUser.Text = "NamaLengkapUser             ";
            lbNamaLengkapUser.Click += lbNamaLengkapUser_Click;
            // 
            // btHapusUser
            // 
            btHapusUser.BackColor = Color.Red;
            btHapusUser.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btHapusUser.ForeColor = Color.White;
            btHapusUser.Location = new Point(1341, 26);
            btHapusUser.Name = "btHapusUser";
            btHapusUser.Size = new Size(125, 43);
            btHapusUser.TabIndex = 22;
            btHapusUser.Text = "Hapus";
            btHapusUser.UseVisualStyleBackColor = false;
            btHapusUser.Click += btHapusUser_Click;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUsername.ForeColor = Color.Black;
            lbUsername.Location = new Point(24, 30);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(231, 32);
            lbUsername.TabIndex = 20;
            lbUsername.Text = "Username              ";
            lbUsername.Click += lbUsername_Click;
            // 
            // btEditUser
            // 
            btEditUser.BackColor = Color.DarkOrange;
            btEditUser.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btEditUser.ForeColor = Color.White;
            btEditUser.Location = new Point(1210, 26);
            btEditUser.Name = "btEditUser";
            btEditUser.Size = new Size(125, 43);
            btEditUser.TabIndex = 19;
            btEditUser.Text = "Edit";
            btEditUser.UseVisualStyleBackColor = false;
            btEditUser.Click += btEditUser_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.CardMonitorStok__1_;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(374, 248);
            panel3.Name = "panel3";
            panel3.Size = new Size(1497, 67);
            panel3.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(100, 60, 20);
            label4.Location = new Point(1018, 19);
            label4.Name = "label4";
            label4.Size = new Size(89, 32);
            label4.TabIndex = 25;
            label4.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(100, 60, 20);
            label3.Location = new Point(761, 19);
            label3.Name = "label3";
            label3.Size = new Size(68, 32);
            label3.TabIndex = 24;
            label3.Text = "Role";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(100, 60, 20);
            label2.Location = new Point(339, 19);
            label2.Name = "label2";
            label2.Size = new Size(197, 32);
            label2.TabIndex = 23;
            label2.Text = "Nama Lengkap";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(100, 60, 20);
            label1.Location = new Point(38, 19);
            label1.Name = "label1";
            label1.Size = new Size(133, 32);
            label1.TabIndex = 22;
            label1.Text = "Username";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Tambah_dan_refresh;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(btRefresh);
            panel2.Controls.Add(btTambahUser);
            panel2.Location = new Point(374, 153);
            panel2.Name = "panel2";
            panel2.Size = new Size(385, 55);
            panel2.TabIndex = 17;
            // 
            // btRefresh
            // 
            btRefresh.BackColor = Color.OldLace;
            btRefresh.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btRefresh.ForeColor = Color.FromArgb(100, 60, 20);
            btRefresh.Location = new Point(279, 7);
            btRefresh.Name = "btRefresh";
            btRefresh.Size = new Size(101, 41);
            btRefresh.TabIndex = 18;
            btRefresh.Text = "Refresh";
            btRefresh.UseVisualStyleBackColor = false;
            btRefresh.Click += btRefresh_Click;
            // 
            // btTambahUser
            // 
            btTambahUser.BackColor = Color.OldLace;
            btTambahUser.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTambahUser.ForeColor = Color.FromArgb(100, 60, 20);
            btTambahUser.Location = new Point(53, 7);
            btTambahUser.Name = "btTambahUser";
            btTambahUser.Size = new Size(164, 41);
            btTambahUser.TabIndex = 19;
            btTambahUser.Text = "Tambah User";
            btTambahUser.UseVisualStyleBackColor = false;
            btTambahUser.Click += btTambahUser_Click;
            // 
            // btLogout
            // 
            btLogout.BackColor = Color.Red;
            btLogout.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogout.ForeColor = Color.White;
            btLogout.Location = new Point(37, 912);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(224, 41);
            btLogout.TabIndex = 11;
            btLogout.Text = "Logout";
            btLogout.UseVisualStyleBackColor = false;
            btLogout.Click += btLogout_Click;
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
            // V_KelolaAkunUserr
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panel1);
            Name = "V_KelolaAkunUserr";
            Text = "V_KelolaAkunUserr";
            panel1.ResumeLayout(false);
            flpKelolaUser.ResumeLayout(false);
            pmonitorstok.ResumeLayout(false);
            pmonitorstok.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
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
        private Panel panel2;
        private Button btRefresh;
        private Button btTambahUser;
        private FlowLayoutPanel flpKelolaUser;
        private Panel pmonitorstok;
        private Button btHapusUser;
        private Label lbUsername;
        private Button btEditUser;
        private Panel panel3;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lbNamaLengkapUser;
        private Label label4;
        private Label lbstatusUser;
        private Label lbRoleUser;
    }
}