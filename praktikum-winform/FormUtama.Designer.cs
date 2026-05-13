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
            panelHeader  = new Panel();
            lblJudul     = new Label();
            lblSubJudul  = new Label();
            panelKonten  = new Panel();
            panelUtama   = new Panel();

            panelHeader.SuspendLayout();
            panelKonten.SuspendLayout();
            SuspendLayout();

            // ─── panelHeader (bar atas) ───────────────────────────────
            panelHeader.BackColor  = System.Drawing.Color.FromArgb(30, 58, 138);   // biru gelap
            panelHeader.Dock       = DockStyle.Top;
            panelHeader.Height     = 80;
            panelHeader.Controls.Add(lblSubJudul);
            panelHeader.Controls.Add(lblJudul);
            panelHeader.Name       = "panelHeader";
            panelHeader.TabIndex   = 0;

            // ─── lblJudul ─────────────────────────────────────────────
            lblJudul.AutoSize  = true;
            lblJudul.Font      = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            lblJudul.ForeColor = System.Drawing.Color.White;
            lblJudul.Location  = new System.Drawing.Point(24, 10);
            lblJudul.Name      = "lblJudul";
            lblJudul.Text      = "Sistem Manajemen Mahasiswa";

            // ─── lblSubJudul ──────────────────────────────────────────
            lblSubJudul.AutoSize  = true;
            lblSubJudul.Font      = new System.Drawing.Font("Segoe UI", 10F);
            lblSubJudul.ForeColor = System.Drawing.Color.FromArgb(180, 210, 255);
            lblSubJudul.Location  = new System.Drawing.Point(26, 46);
            lblSubJudul.Name      = "lblSubJudul";
            lblSubJudul.Text      = "Praktikum Pemrograman Visual";

            // ─── panelKonten (area abu-abu luar, padding visual) ──────
            panelKonten.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            panelKonten.Dock      = DockStyle.Fill;
            panelKonten.Name      = "panelKonten";
            panelKonten.TabIndex  = 1;
            panelKonten.Padding   = new Padding(30, 24, 30, 24);
            panelKonten.Controls.Add(panelUtama);

            // ─── panelUtama (konten form anak, putih, dengan shadow) ──
            panelUtama.BackColor  = System.Drawing.Color.White;
            panelUtama.Dock       = DockStyle.Fill;
            panelUtama.Name       = "panelUtama";
            panelUtama.TabIndex   = 0;

            // ─── FormUtama ────────────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode       = AutoScaleMode.Font;
            BackColor           = System.Drawing.Color.FromArgb(240, 242, 245);
            ClientSize          = new System.Drawing.Size(1143, 750);
            Controls.Add(panelKonten);
            Controls.Add(panelHeader);
            Name    = "FormUtama";
            Text    = "Sistem Manajemen Mahasiswa";

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
