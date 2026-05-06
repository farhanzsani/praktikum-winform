namespace praktikum_winform
{
    public partial class Form1 : Form
    {
        private string usename;
        private string password;

        public Form1()
        {
            InitializeComponent();
            usename = "Admin";
            password = "password";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputUsername = TbUsername.Text;
            string inputPassword = TbPassword.Text;

            if (inputUsername == usename && inputPassword == password)
            {
                MessageBox.Show("Login Berhasil", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormDashboard halamanDashboard = new FormDashboard(inputUsername);
                halamanDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username/Password Anda Salah", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
