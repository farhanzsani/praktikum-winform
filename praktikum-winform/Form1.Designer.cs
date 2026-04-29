namespace praktikum_winform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TbUsername = new TextBox();
            TbPassword = new TextBox();
            BtnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo_unej;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(226, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 133);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(BtnLogin);
            panel1.Controls.Add(TbPassword);
            panel1.Controls.Add(TbUsername);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(94, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(614, 360);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Coalition", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(209, 154);
            label1.Name = "label1";
            label1.Size = new Size(199, 24);
            label1.TabIndex = 1;
            label1.Text = "SISTEM LOGIN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(258, 178);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(258, 239);
            label3.Name = "label3";
            label3.Size = new Size(85, 21);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // TbUsername
            // 
            TbUsername.Location = new Point(209, 202);
            TbUsername.Name = "TbUsername";
            TbUsername.Size = new Size(199, 23);
            TbUsername.TabIndex = 4;
            // 
            // TbPassword
            // 
            TbPassword.Location = new Point(209, 263);
            TbPassword.Name = "TbPassword";
            TbPassword.Size = new Size(199, 23);
            TbPassword.TabIndex = 5;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.LimeGreen;
            BtnLogin.Font = new Font("Space Quest", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnLogin.Location = new Point(209, 305);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(199, 36);
            BtnLogin.TabIndex = 6;
            BtnLogin.Text = "LOGIN";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Awas__Ini_Dia_Bahaya_Selalu_Konsumsi_Gorengan_Saat_Buka_Puasa;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button BtnLogin;
        private TextBox TbPassword;
        private TextBox TbUsername;
    }
}
