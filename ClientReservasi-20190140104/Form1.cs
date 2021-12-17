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
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
        public Form1()
        {
            InitializeComponent();

            TampilData();
            btnUpdate.Enabled = false;
            btnHapus.Enabled = false;
                
        }

        public void TampilData()
        {
            var List = service.Pemesanans();
            dtPemesanan.DataSource = List;
        }

        public void Clear()
        {
            tbID.Clear();
            tbNama.Clear();
            tbNoTlp.Clear();
            tbJmlPemesanan.Clear();
            tbIdLoksi.Clear();

            tbJmlPemesanan.Enabled = true;
            tbIdLoksi.Enabled = true;

            btnSimpan.Enabled = true;
            btnUpdate.Enabled = false;
            btnHapus.Enabled = false;

            tbID.Enabled = true;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            int IdPemesanan = int.Parse(tbID.Text);
            string NamaCustomer = tbNama.Text;
            string NoTelepon = tbNoTlp.Text;
            int JmlPemesanan = int.Parse(tbJmlPemesanan.Text);
            string IdLokasi = tbIdLoksi.Text;

            var a = service.pemesanan(IdPemesanan, NamaCustomer, NoTelepon, JmlPemesanan, IdLokasi);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string IdPemesanan = tbID.Text;
            string NamaCustomer = tbNama.Text;
            string NoTelepon = tbNoTlp.Text;

            var a = service.editPemesanan(IdPemesanan, NamaCustomer, NoTelepon);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string IdPemesanan = tbID.Text;

            var a = service.deletePemesanan(IdPemesanan);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dtPemesanan_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            tbID.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[0].Value);
            tbNama.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[3].Value);
            tbNoTlp.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[4].Value);
            tbJmlPemesanan.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[1].Value);
            tbIdLoksi.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[2].Value);

            tbJmlPemesanan.Enabled = false;
            tbIdLoksi.Enabled = false;

            btnUpdate.Enabled = true;
            btnHapus.Enabled = true;
            btnSimpan.Enabled = false;

            tbID.Enabled = false;
        }
    }
}
