using System;
using System.Windows.Forms;

namespace praktikum_winform
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();

            // Saat aplikasi jalan, langsung buka FromLogin ke dalam panel.
            // Kita mengirimkan 'this' (FormUtama) agar FromLogin mengenali siapa induknya.
            BukaFormDiPanel(new FromLogin(this));
        }

        // Fungsi untuk mengganti isi panel
        public void BukaFormDiPanel(Form formAnak)
        {
            if (this.panelUtama.Controls.Count > 0)
            {
                this.panelUtama.Controls[0].Dispose(); // Bersihkan form sebelumnya
                this.panelUtama.Controls.Clear();
            }

            formAnak.TopLevel = false;
            formAnak.FormBorderStyle = FormBorderStyle.None;
            formAnak.Dock = DockStyle.Fill;

            this.panelUtama.Controls.Add(formAnak);
            this.panelUtama.Tag = formAnak;
            formAnak.Show();
        }

        private void panelUtama_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
