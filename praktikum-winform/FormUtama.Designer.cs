namespace praktikum_winform
{
    partial class FormUtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblSubJudul = new Label();
            lblJudul = new Label();
            panelKonten = new Panel();
            panelUtama = new Panel();
            panelHeader.SuspendLayout();
            panelKonten.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(30, 58, 138);
            panelHeader.Controls.Add(lblSubJudul);
            panelHeader.Controls.Add(lblJudul);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1143, 80);
            panelHeader.TabIndex = 0;
            // 
            // lblSubJudul
            // 
            lblSubJudul.AutoSize = true;
            lblSubJudul.Font = new Font("Segoe UI", 10F);
            lblSubJudul.ForeColor = Color.FromArgb(180, 210, 255);
            lblSubJudul.Location = new Point(26, 46);
            lblSubJudul.Name = "lblSubJudul";
            lblSubJudul.Size = new Size(274, 19);
            lblSubJudul.TabIndex = 0;
            lblSubJudul.Text = "Praktikum Pemrograman Berorientasi objek";
            lblSubJudul.Click += lblSubJudul_Click;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblJudul.ForeColor = Color.White;
            lblJudul.Location = new Point(24, 10);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(361, 32);
            lblJudul.TabIndex = 1;
            lblJudul.Text = "Sistem Manajemen Mahasiswa";
            // 
            // panelKonten
            // 
            panelKonten.BackColor = Color.FromArgb(240, 242, 245);
            panelKonten.Controls.Add(panelUtama);
            panelKonten.Dock = DockStyle.Fill;
            panelKonten.Location = new Point(0, 80);
            panelKonten.Name = "panelKonten";
            panelKonten.Padding = new Padding(30, 24, 30, 24);
            panelKonten.Size = new Size(1143, 670);
            panelKonten.TabIndex = 1;
            // 
            // panelUtama
            // 
            panelUtama.BackColor = Color.White;
            panelUtama.Dock = DockStyle.Fill;
            panelUtama.Location = new Point(30, 24);
            panelUtama.Name = "panelUtama";
            panelUtama.Size = new Size(1083, 622);
            panelUtama.TabIndex = 0;
            // 
            // FormUtama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(1143, 750);
            Controls.Add(panelKonten);
            Controls.Add(panelHeader);
            Name = "FormUtama";
            Text = "Sistem Manajemen Mahasiswa";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelKonten.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblJudul;
        private Label lblSubJudul;
        private Panel panelKonten;
        private Panel panelUtama;
    }
}
