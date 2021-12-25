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
    public partial class Login : Form
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usename = tbUsername.Text;
            string password = tbPassword.Text;

            string kategori = service.Login(usename, password);

            if(kategori == "Admin")
            {
                Register register = new Register();
                this.Hide();
                register.Show();
            }
            else if (kategori == "Resepsionis")
            {
                Reservasi reservasi = new Reservasi();
                this.Hide();
                reservasi.Show();
            }
            else
            {
                MessageBox.Show("Username dan Password TIDAK Valid, silakan menghubungin Admin");
                tbUsername.Clear();
                tbPassword.Clear();
            }
        }
    }
}
