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
    public partial class clanipodatki : Form
    {
        int idu;
        public clanipodatki(int id)
        {
            InitializeComponent();
            idu = id;
            polnjenje();
        }
      
        private void polnjenje()
        {
            Users uporabnik = baza.IzpisVsePodatkeOUser(idu);
            imetext.Text = uporabnik.name;
            pritext.Text = uporabnik.surname;
            teltext.Text = uporabnik.telephone;
            nasltext.Text = uporabnik.address;
            emailtext.Text = uporabnik.email;
            opombetext.Text = uporabnik.notes;

        }
        private void nazajbutton_Click(object sender, EventArgs e)
        {
            main ma = new main();
            ma.Show(); 
            this.Close();
        }

        private void uredibutton_Click(object sender, EventArgs e)
        {
            imetext.Enabled = true;
            pritext.Enabled = true;
            teltext.Enabled = true;
            nasltext.Enabled = true;
            emailtext.Enabled = true;
            opombetext.Enabled = true;

            uredibutton.Visible = false;
            potrdibutton.Visible = true;
            cancel_button.Visible = true; 
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            imetext.Enabled = false;
            pritext.Enabled = false;
            teltext.Enabled = false;
            nasltext.Enabled = false;
            emailtext.Enabled = false;
            opombetext.Enabled = false;

            uredibutton.Visible = true;
            potrdibutton.Visible = false;
            potrdibutton.Visible = false;
            polnjenje();
        }

        private void potrdibutton_Click(object sender, EventArgs e)
        {
            bool ok = baza.PreverjanjeUporabnika(emailtext.Text, teltext.Text, idu);
            if(ok == false)
            {
                MessageBox.Show("Uporabnik z enakim E-naslovom ali telefonom že obstaja");
            }
            else
            {
                Users user = new Users(imetext.Text, pritext.Text, teltext.Text, nasltext.Text, emailtext.Text, opombetext.Text);
                baza.UpdateUporabnika(user, idu);
                imetext.Enabled = false;
                pritext.Enabled = false;
                teltext.Enabled = false;
                nasltext.Enabled = false;
                emailtext.Enabled = false;
                opombetext.Enabled = false;

                uredibutton.Visible = true;
                potrdibutton.Visible = false;
                cancel_button.Visible = false;

            }     
        }

        private void izposojaVrnitevButton_Click(object sender, EventArgs e)
        {
            knjigaClani vrnitevKnjig = new knjigaClani(idu);
            vrnitevKnjig.Show();
        }
    }
}
