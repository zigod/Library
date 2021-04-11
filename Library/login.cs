using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void prijavaButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string geslo = gesloBox.Text;

            bool prijava = baza.Prijava(username, geslo);

            if (prijava == true)
            {
                Form mainform = new main();
                this.Hide();
                mainform.Show();
            }
            else
            {
                MessageBox.Show("Narobe prijava");
            }
        }

    
    }
}
