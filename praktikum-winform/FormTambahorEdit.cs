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
    public partial class FormTambahorEdit : Form
    {
        private User _userEdit;           // null = mode Tambah, isi = mode Edit
        private FormDashboard _dashboard; // referensi ke dashboard pemanggil

        // Constructor: menerima user (null jika tambah) dan dashboard induk
        public FormTambahorEdit(User userEdit, FormDashboard dashboard)
        {
            InitializeComponent();
            _userEdit = userEdit;
            _dashboard = dashboard;

            if (_userEdit != null)
            {
                // Mode Edit — isi field dengan data yang sudah ada
                label1.Text = "Edit Data Mahasiswa";
                tb_NamaForm.Text = _userEdit.nama;
                tb_AsalForm.Text = _userEdit.asal;
                tb_UmurForm.Text = _userEdit.umur.ToString();
            }
            else
            {
                // Mode Tambah
                label1.Text = "Tambah Data Mahasiswa";
            }
        }

        // ─── Tombol Simpan ────────────────────────────────────────────
        private void bt_Simpan_Click(object sender, EventArgs e)
        {
            string nama = tb_NamaForm.Text.Trim();
            string asal = tb_AsalForm.Text.Trim();
            string umurStr = tb_UmurForm.Text.Trim();

            if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(asal) || string.IsNullOrEmpty(umurStr))
            {
                MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(umurStr, out int umur))
            {
                MessageBox.Show("Umur harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_userEdit != null)
            {
                // Mode Edit — update data yang ada
                _userEdit.nama = nama;
                _userEdit.asal = asal;
                _userEdit.umur = umur;
                MessageBox.Show("Data berhasil diperbarui.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Mode Tambah — tambah user baru ke daftar di dashboard
                int newId = _dashboard.data.Count > 0 ? _dashboard.data.Max(u => u.Id) + 1 : 1;
                User userBaru = new User(newId, nama, umur, asal);
                _dashboard.data.Add(userBaru);
                MessageBox.Show("Data berhasil ditambahkan.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }

        // ─── Tombol Batal ────────────────────────────────────────────
        private void bt_Batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
