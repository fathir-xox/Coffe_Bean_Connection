namespace FinalProjek.View.Admin_View
{
    partial class V_TambahKategori
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
            tbNamaKategori = new TextBox();
            tbDeskripsiKategori = new TextBox();
            btSIMPAN = new Button();
            SuspendLayout();
            // 
            // tbNamaKategori
            // 
            tbNamaKategori.Location = new Point(338, 112);
            tbNamaKategori.Name = "tbNamaKategori";
            tbNamaKategori.Size = new Size(150, 31);
            tbNamaKategori.TabIndex = 0;
            // 
            // tbDeskripsiKategori
            // 
            tbDeskripsiKategori.Location = new Point(334, 197);
            tbDeskripsiKategori.Name = "tbDeskripsiKategori";
            tbDeskripsiKategori.Size = new Size(150, 31);
            tbDeskripsiKategori.TabIndex = 1;
            // 
            // btSIMPAN
            // 
            btSIMPAN.BackColor = Color.FromArgb(100, 60, 20);
            btSIMPAN.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSIMPAN.ForeColor = Color.OldLace;
            btSIMPAN.Location = new Point(338, 293);
            btSIMPAN.Name = "btSIMPAN";
            btSIMPAN.Size = new Size(140, 46);
            btSIMPAN.TabIndex = 5;
            btSIMPAN.Text = "SIMPAN";
            btSIMPAN.UseVisualStyleBackColor = false;
            btSIMPAN.Click += btSIMPAN_Click;
            // 
            // V_TambahKategori
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btSIMPAN);
            Controls.Add(tbDeskripsiKategori);
            Controls.Add(tbNamaKategori);
            Name = "V_TambahKategori";
            Text = "V_TambahKategori";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNamaKategori;
        private TextBox tbDeskripsiKategori;
        private Button btSIMPAN;
    }
}