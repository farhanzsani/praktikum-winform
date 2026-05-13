using System;
using System.Windows.Forms;

namespace praktikum_winform
{
    public partial class FromLogin : Form
    {
        private string usename;
        private string password;

        // Variabel untuk menyimpan referensi form induk pembungkus
        private FormUtama _induk;

        // Constructor lama (tetap dipertahankan)
        public FromLogin()
        {
            InitializeComponent();
            usename = "Admin";
            password = "password";
            _induk = null;
        }

        // Constructor baru: menerima informasi siapa FormUtama-nya
        public FromLogin(FormUtama induk)
        {
            InitializeComponent();
            usename = "Admin";
            password = "password";
            _induk = induk;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usernameInput = TbUsername.Text.Trim();
            string passwordInput = TbPassword.Text;

            if (usernameInput == this.usename && passwordInput == this.password)
            {
                MessageBox.Show("Login Berhasil", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (_induk != null)
                {
                    _induk.BukaFormDiPanel(new FormDashboard(usernameInput, _induk));
                }
                else
                {
                    FormDashboard halamanDashboard = new FormDashboard(usernameInput);
                    halamanDashboard.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Username/Password Anda Salah", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FromLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
