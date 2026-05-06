using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikum_winform
{
    public partial class FormDashboard : Form
    {
        private string usernames;
        private List<User> data;
        public FormDashboard(string username)
        {
            InitializeComponent();
            this.usernames = username;
            lb_SelamatDatang.Text += this.usernames;
            this.data = buatData();
            dg_DataDashboard.DataSource = data;
        }

    public List<User> buatData()
        {
            List<User> data = new List<User>();
            for (int i = 0; i < 5; i++)
            {
                User user = new User($"Budi{i}", 21, "Jember");
                data.Add(user);
            }
            return data;
        }

    } 
}
