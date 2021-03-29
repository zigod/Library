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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            polnjenje();
        }

       

        private void polnjenje()
        {
            List<knjige> knjiga = baza.izpisvsehknjig();
            List<Users> user = baza.IzpisUsers();
            foreach (knjige x in knjiga)
            {
                knjigegrid.Rows.Add(new object[] { x.inventarna_st,x.Naslov,x.Avtor,x.Leto,x.Section,x.Zalozba });
            }

            foreach (Users x in user)
            {
                usersgrid.Rows.Add(new object[] { x.name, x.surname, x.telephone, x.email });
            }
        }

        private void dodajClanaButton_Click(object sender, EventArgs e)
        {
            string ime = imeBox.Text;
            string priimek = priimekBox.Text;
            string telefon = telefonBox.Text;
            string naslov = naslovBox.Text;
            string email = gmailBox.Text;
            string opombe = opombeBox.Text;

            baza.DodajClana(ime, priimek, telefon, naslov, email, opombe);
        }
    }
}
