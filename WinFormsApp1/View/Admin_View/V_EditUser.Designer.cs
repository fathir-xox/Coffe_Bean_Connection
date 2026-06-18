namespace FinalProjek.View.Admin_View
{
    partial class V_EditUser
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
            btnSimpan = new Button();
            cbStatus = new ComboBox();
            cbRole = new ComboBox();
            txtFullName = new TextBox();
            txtUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.V_EditUser;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(btnSimpan);
            panel1.Controls.Add(cbStatus);
            panel1.Controls.Add(cbRole);
            panel1.Controls.Add(txtFullName);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-106, -19);
            panel1.Name = "panel1";
            panel1.Size = new Size(1466, 716);
            panel1.TabIndex = 0;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(100, 60, 20);
            btnSimpan.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSimpan.ForeColor = Color.OldLace;
            btnSimpan.Location = new Point(584, 546);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(295, 46);
            btnSimpan.TabIndex = 8;
            btnSimpan.Text = "SIMPAN";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(590, 469);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(285, 33);
            cbStatus.TabIndex = 7;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(590, 387);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(286, 33);
            cbRole.TabIndex = 6;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(589, 309);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(285, 31);
            txtFullName.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(590, 225);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(285, 31);
            txtUsername.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(100, 60, 20);
            label4.Location = new Point(585, 267);
            label4.Name = "label4";
            label4.Size = new Size(159, 27);
            label4.TabIndex = 3;
            label4.Text = "Nama Lengkap";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(100, 60, 20);
            label3.Location = new Point(585, 352);
            label3.Name = "label3";
            label3.Size = new Size(57, 27);
            label3.TabIndex = 2;
            label3.Text = "Role";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(100, 60, 20);
            label2.Location = new Point(585, 434);
            label2.Name = "label2";
            label2.Size = new Size(70, 27);
            label2.TabIndex = 1;
            label2.Text = "Status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(100, 60, 20);
            label1.Location = new Point(585, 186);
            label1.Name = "label1";
            label1.Size = new Size(108, 27);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // V_EditUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 664);
            Controls.Add(panel1);
            Name = "V_EditUser";
            Text = "V_EditUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cbStatus;
        private ComboBox cbRole;
        private TextBox txtFullName;
        private TextBox txtUsername;
        private Button btnSimpan;
    }
}