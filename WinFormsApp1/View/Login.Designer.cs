namespace FinalProjek.View
{
    partial class Login
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.login__3_;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btLogin);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 453);
            panel1.TabIndex = 0;
            // 
            // btLogin
            // 
            btLogin.BackColor = Color.Wheat;
            btLogin.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogin.ForeColor = Color.FromArgb(128, 64, 64);
            btLogin.Location = new Point(477, 338);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(226, 45);
            btLogin.TabIndex = 3;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(128, 64, 64);
            label3.Location = new Point(477, 256);
            label3.Name = "label3";
            label3.Size = new Size(69, 19);
            label3.TabIndex = 2;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 64, 64);
            label2.Location = new Point(477, 179);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 1;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 64, 64);
            label1.Location = new Point(545, 119);
            label1.Name = "label1";
            label1.Size = new Size(91, 26);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(490, 206);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(490, 285);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 31);
            textBox2.TabIndex = 5;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button btLogin;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}