using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientReservasi_20190140104
{
    public partial class Register : Form
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
        public Register()
        {
            InitializeComponent();
            TampilData();
            tBoxID.Visible = false;
            btnUpdate.Enabled = false;
            btnHapus.Enabled = false;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string username = tBoxUsername.Text;
            string password = tBoxPassword.Text;
            string kategori = cBoxKategori.Text;
            string a = service.Register(username, password, kategori);

            if(tBoxPassword.Text == "" || tBoxUsername.Text == "" || cBoxKategori.Text == "")
            {
                MessageBox.Show("Semua Kolom Harus Diisi!!!");
            }
            else
            {
                MessageBox.Show(a);
                Refresh();
                TampilData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string username = tBoxUsername.Text;
            string password = tBoxPassword.Text;
            string kategori = cBoxKategori.Text;
            int id = Convert.ToInt32(tBoxID.Text);

            string a = service.UpdateRegister(username, password, kategori, id);

            if (tBoxPassword.Text == "" || tBoxUsername.Text == "" || cBoxKategori.Text == "")
            {
                MessageBox.Show("Semua Kolom Harus Diisi!!!");
            }
            else
            {
                MessageBox.Show(a);
                Clear();
                TampilData();
            }
        }        

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string username = tBoxUsername.Text;

            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Hapus Data", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                string a = service.DeleteRegister(username);
                MessageBox.Show(a);
                Clear();
                TampilData();
            }
            else if(dialogResult == DialogResult.No)
            {

            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void TampilData()
        {
            var list = service.DataRegisters();
            dgvRegister.DataSource = list;
        }

        public void Clear()
        {
            tBoxUsername.Clear();
            tBoxPassword.Clear();
            cBoxKategori.SelectedItem = null;

            btnSimpan.Enabled = true;
            btnUpdate.Enabled = false;
            btnHapus.Enabled = false;
        }

        private void dgvRegister_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tBoxID.Text = Convert.ToString(dgvRegister.Rows[e.RowIndex].Cells[0].Value);
            tBoxUsername.Text = Convert.ToString(dgvRegister.Rows[e.RowIndex].Cells[1].Value);
            tBoxPassword.Text = Convert.ToString(dgvRegister.Rows[e.RowIndex].Cells[2].Value);
            cBoxKategori.Text = Convert.ToString(dgvRegister.Rows[e.RowIndex].Cells[3].Value);

            btnUpdate.Enabled = true;
            btnHapus.Enabled = true;

            btnSimpan.Enabled = false;
        }
    }
}
