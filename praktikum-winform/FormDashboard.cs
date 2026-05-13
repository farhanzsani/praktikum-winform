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
        public List<User> data;
        private FormUtama _induk;

        // Constructor lama (tetap dipertahankan)
        public FormDashboard(string username)
        {
            InitializeComponent();
            this.usernames = username;
            this._induk = null;
            lb_SelamatDatang.Text += this.usernames;
            LoadData();
        }

        // Constructor baru: menerima FormUtama sebagai induk
        public FormDashboard(string username, FormUtama induk)
        {
            InitializeComponent();
            this.usernames = username;
            this._induk = induk;
            lb_SelamatDatang.Text += this.usernames;
            LoadData();
        }

        private void LoadData()
        {
            this.data = buatData();
            dg_DataDashboard.DataSource = data;

            dg_DataDashboard.Columns["bt_HapusData"].DisplayIndex = dg_DataDashboard.Columns.Count - 1;
            dg_DataDashboard.Columns["bt_EditData"].DisplayIndex = dg_DataDashboard.Columns.Count - 2;
        }

        public List<User> buatData()
        {
            List<User> hasil = new List<User>();
            for (int i = 1; i <= 5; i++)
            {
                User user = new User(i, "Budi " + i, 21, "Jember");
                hasil.Add(user);
            }
            return hasil;
        }

        // ─── Tombol Tambah ───────────────────────────────────────────
        private void bt_TambahData_Click(object sender, EventArgs e)
        {
            FormTambahorEdit formTambah = new FormTambahorEdit(null, this);
            formTambah.ShowDialog();
            // Refresh data setelah form ditutup
            LoadData();
        }

        // ─── Tombol Edit & Hapus di dalam DataGridView ───────────────
        private void dg_DataDashboard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pastikan klik pada baris data, bukan header
            if (e.RowIndex < 0) return;

            string columnName = dg_DataDashboard.Columns[e.ColumnIndex].Name;

            // Ambil data user pada baris yang diklik
            User userDipilih = data[e.RowIndex];

            if (columnName == "bt_EditData")
            {
                // Buka form edit dengan data user yang dipilih
                FormTambahorEdit formEdit = new FormTambahorEdit(userDipilih, this);
                formEdit.ShowDialog();
                // Refresh data setelah form ditutup
                LoadData();
            }
            else if (columnName == "bt_HapusData")
            {
                DialogResult konfirmasi = MessageBox.Show(
                    $"Yakin ingin menghapus data \"{userDipilih.nama}\"?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (konfirmasi == DialogResult.Yes)
                {
                    data.RemoveAt(e.RowIndex);
                    dg_DataDashboard.DataSource = null;
                    dg_DataDashboard.DataSource = data;
                    MessageBox.Show("Data berhasil dihapus.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
