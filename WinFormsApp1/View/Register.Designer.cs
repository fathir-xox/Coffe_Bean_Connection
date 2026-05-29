namespace FinalProjek.View
{
    partial class Register
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
            btLogin = new Button();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            tbFullNameRegister = new TextBox();
            tbUsernameRegister = new TextBox();
            tbPasswordRegister = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.login__5_;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(tbPasswordRegister);
            panel1.Controls.Add(tbUsernameRegister);
            panel1.Controls.Add(tbFullNameRegister);
            panel1.Controls.Add(btLogin);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 452);
            panel1.TabIndex = 0;
            // 
            // btLogin
            // 
            btLogin.BackColor = Color.Wheat;
            btLogin.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogin.ForeColor = Color.FromArgb(128, 64, 64);
            btLogin.Location = new Point(308, 358);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(226, 45);
            btLogin.TabIndex = 4;
            btLogin.Text = "Register";
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(128, 64, 64);
            label4.Location = new Point(312, 120);
            label4.Name = "label4";
            label4.Size = new Size(103, 19);
            label4.TabIndex = 4;
            label4.Text = "Nama Lengkap";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(128, 64, 64);
            label3.Location = new Point(312, 271);
            label3.Name = "label3";
            label3.Size = new Size(69, 19);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 64, 64);
            label1.Location = new Point(311, 196);
            label1.Name = "label1";
            label1.Size = new Size(70, 19);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 64, 64);
            label2.Location = new Point(363, 85);
            label2.Name = "label2";
            label2.Size = new Size(133, 26);
            label2.TabIndex = 1;
            label2.Text = "REGISTER";
            label2.Click += label2_Click;
            // 
            // tbFullNameRegister
            // 
            tbFullNameRegister.BackColor = Color.White;
            tbFullNameRegister.ForeColor = Color.Black;
            tbFullNameRegister.Location = new Point(324, 151);
            tbFullNameRegister.Name = "tbFullNameRegister";
            tbFullNameRegister.Size = new Size(198, 31);
            tbFullNameRegister.TabIndex = 5;
            // 
            // tbUsernameRegister
            // 
            tbUsernameRegister.BackColor = Color.White;
            tbUsernameRegister.ForeColor = Color.Black;
            tbUsernameRegister.Location = new Point(324, 225);
            tbUsernameRegister.Name = "tbUsernameRegister";
            tbUsernameRegister.Size = new Size(198, 31);
            tbUsernameRegister.TabIndex = 6;
            // 
            // tbPasswordRegister
            // 
            tbPasswordRegister.BackColor = Color.White;
            tbPasswordRegister.ForeColor = Color.Black;
            tbPasswordRegister.Location = new Point(323, 299);
            tbPasswordRegister.Name = "tbPasswordRegister";
            tbPasswordRegister.Size = new Size(198, 31);
            tbPasswordRegister.TabIndex = 7;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Register";
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Button btLogin;
        private TextBox tbPasswordRegister;
        private TextBox tbUsernameRegister;
        private TextBox tbFullNameRegister;
    }
}