namespace FinalProjek.View.Admin_View
{
    partial class V_TambahKategori
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox tbNamaKategori;
        private Button btSIMPAN;
        private Panel panel1;
        private RichTextBox rtbDeskripsiKategori;

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
            tbNamaKategori = new TextBox();
            btSIMPAN = new Button();
            panel1 = new Panel();
            rtbDeskripsiKategori = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbNamaKategori
            // 
            tbNamaKategori.Location = new Point(521, 198);
            tbNamaKategori.Name = "tbNamaKategori";
            tbNamaKategori.Size = new Size(284, 31);
            tbNamaKategori.TabIndex = 0;
            // 
            // btSIMPAN
            // 
            btSIMPAN.BackColor = Color.FromArgb(100, 60, 20);
            btSIMPAN.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btSIMPAN.ForeColor = Color.OldLace;
            btSIMPAN.Location = new Point(521, 522);
            btSIMPAN.Name = "btSIMPAN";
            btSIMPAN.Size = new Size(284, 46);
            btSIMPAN.TabIndex = 5;
            btSIMPAN.Text = "SIMPAN";
            btSIMPAN.UseVisualStyleBackColor = false;
            btSIMPAN.Click += btSIMPAN_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.VTambahKategori;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(rtbDeskripsiKategori);
            panel1.Controls.Add(btSIMPAN);
            panel1.Controls.Add(tbNamaKategori);
            panel1.Location = new Point(-37, -21);
            panel1.Name = "panel1";
            panel1.Size = new Size(1328, 719);
            panel1.TabIndex = 6;
            // 
            // rtbDeskripsiKategori
            // 
            rtbDeskripsiKategori.Location = new Point(521, 293);
            rtbDeskripsiKategori.Name = "rtbDeskripsiKategori";
            rtbDeskripsiKategori.Size = new Size(284, 143);
            rtbDeskripsiKategori.TabIndex = 6;
            rtbDeskripsiKategori.Text = "";
            // 
            // V_TambahKategori
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 664);
            Controls.Add(panel1);
            Name = "V_TambahKategori";
            Text = "Tambah Kategori";
            Load += V_TambahKategori_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }
    }
}