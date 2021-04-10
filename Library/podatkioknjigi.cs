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
    public partial class podatkioknjigi : Form
    {
        int id;
        public podatkioknjigi(int idk)
        {
            InitializeComponent();
            id = idk;
            polnjenje();
        }

        private void polnjenje()
        {
            knjige kn = baza.PodatkiOknjigi(id);
            invtext.Text = kn.inventarna_st.ToString();
            nastext.Text = kn.Naslov;
            avtext.Text = kn.Avtor;
            zatext.Text = kn.Zalozba;
            letext.Text = kn.Leto.ToString();
            odtext.Text = kn.Section;
            if(kn.Lost == 1)
            {
                ja_izgubljena.Checked = true;

            }
            else
            {
                ne_izgubljena.Checked = true;
            }
            nacintext.Text = kn.Shop;
            optext.Text = kn.notes;
            string stat = "";
            if (kn.Status == 0)
            {
                stat = "Izposojeno";
                vrnibutton.Visible = true;
                spremeniStatusButton.Visible = false;
            }
            else if(kn.Status == 1)
            {
                stat = "Prosto";
                vrnibutton.Visible = false;
                spremeniStatusButton.Visible = true;
            }
            statlabel.Text = statlabel.Text + " " +  stat;
        }

        private void spremeniStatusButton_Click(object sender, EventArgs e)
        {
            spremeniStatus rata = new spremeniStatus(id);
            rata.Show();
            this.Close();
        }

        private void vrnibutton_Click(object sender, EventArgs e)
        {
            bool ok = baza.VrniKnjigoNouid(id);
            if(ok)
                MessageBox.Show("Uspešno vrnjena knjiga");
            else
                MessageBox.Show("Napaka pri vrnitvi");

            polnjenje();
        }

        private void nazajbutton_Click(object sender, EventArgs e)
        {
            main ma = new main();
            ma.Show();
            this.Close();
        }
    }
}
