namespace FinalProjek.View.Kasir_View
{
    partial class KasirDashboardView
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
            btDashboar = new Button();
            panel3 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(100, 60, 20);
            panel1.Controls.Add(btDashboar);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 664);
            panel1.TabIndex = 1;
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
            // 
            // panel2
            // 
            panel2.BackColor = Color.Linen;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(192, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1066, 75);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(100, 60, 20);
            label2.Location = new Point(5, 22);
            label2.Name = "label2";
            label2.Size = new Size(222, 32);
            label2.TabIndex = 3;
            label2.Text = "Dashboard Kasir";
            // 
            // KasirDashboardView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 664);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "KasirDashboardView";
            Text = "KasirDashboardView";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btDashboar;
        private Panel panel3;
        private Label label1;
        private Panel panel2;
        private Label label2;
    }
}