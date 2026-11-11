using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dekstop_c_.vviews
{
    public partial class FormRegisterPetugas : Form
    {
        public FormRegisterPetugas()
        {
            InitializeComponent();
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtNamaPetugas.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtKonfirmasiPassword.Text))
            {
                MessageBox.Show("tidak bole ada yang kosong");
                return;
            }
            if (txtPassword.Text != txtKonfirmasiPassword.Text)
            {
                MessageBox.Show("konfirmasi password salah");
                return;
            }
            if (txtPassword.Text.Length < 6) {
                MessageBox.Show("password harus lebih dari 6 huruf");
                return;
            }
        }

        private void FormRegisterPetugas_Load(object sender, EventArgs e)
        {
            
        }
    }
}
