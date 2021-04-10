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
            sectionsPolnjenje();
        }

        private void sectionsPolnjenje()
        {
            List<string> sections = baza.SelectSections();

            foreach (string x in sections)
            {
                oddelekComboBox.Items.Add(x);
            }
        }
       

        private void polnjenje()
        {
            List<knjige> knjiga = baza.izpisvsehknjig();
            List<Users> user = baza.IzpisUsers();
            foreach (knjige x in knjiga)

            {
                string stat = "";
                if (x.Status == 0)
                    stat = "Izposojeno";
                else
                    stat = "Prosto";

                knjigegrid.Rows.Add(new object[] { x.inventarna_st, x.Naslov, x.Avtor, x.Leto, x.Section, x.Zalozba, "Več", stat});
               
            }
            
            for(int i = 0;i<knjigegrid.Rows.Count;i++)
            {
                
                string stat = Convert.ToString(knjigegrid.Rows[i].Cells[7].Value);
                if (stat == "Izposojeno")
                    knjigegrid.Rows[i].Cells[7].Style.BackColor = Color.Red;
                else
                    knjigegrid.Rows[i].Cells[7].Style.BackColor = Color.Green;

            }
            foreach (Users x in user)
            {
                usersgrid.Rows.Add(new object[] { x.name, x.surname, x.telephone, x.email, "Več",x.id});
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

            Users uporabnik = new Users(ime, priimek, telefon, naslov, email, opombe);

            baza.DodajClana(uporabnik.name, uporabnik.surname, uporabnik.telephone, uporabnik.address, uporabnik.email, uporabnik.notes);

            MessageBox.Show(uporabnik.name +" "+ uporabnik.surname +" "+ uporabnik.telephone +" "+ uporabnik.address +" "+ uporabnik.email +" "+ uporabnik.notes);
        }

        private void usersgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
       
            if (e.ColumnIndex == 4)
            {
                int id = Convert.ToInt32(usersgrid.Rows[e.RowIndex].Cells[5].Value);
                clanipodatki cp = new clanipodatki(id);
                cp.Show();
                this.Close();
            }
        }

        private void knjigegrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
          
            if(e.ColumnIndex == 6)
            {
                int id = Convert.ToInt32(knjigegrid.Rows[e.RowIndex].Cells[0].Value);
                podatkioknjigi pod = new podatkioknjigi(id);
                pod.Show();
                this.Close();
            }
        }

        private void dodajKnjigoButton_Click(object sender, EventArgs e)
        {
            string naslovKnjige = naslovKnjigeTextBox.Text;
            string nacinPridobitve = pridobitevComboBox.SelectedIndex.ToString();
            string oddelek = oddelekComboBox.SelectedItem.ToString();
            int leto = Convert.ToInt32(letoTextbox.Text);
            string avtor = avtorTextBox.Text;
            string zalozba = zalozbaBox.Text;
            string opombe = opombeTextBox.Text;

            knjige knjiga = new knjige(naslovKnjige, nacinPridobitve, oddelek, leto, avtor, zalozba, opombe);

            baza.DodajKnjigo(knjiga.Naslov, knjiga.Shop, knjiga.Section, knjiga.Leto, knjiga.Avtor, knjiga.Zalozba, knjiga.Opomba);
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            List<knjige> search = baza.SearchKnjig(searchbar.Text.ToString());
            knjigegrid.Rows.Clear();
            foreach (knjige x in search)
            {
                knjigegrid.Rows.Add(new object[] { x.inventarna_st, x.Naslov, x.Avtor, x.Leto, x.Section, x.Zalozba, "Več" });
            }
        }

        private void orderbutton_Click(object sender, EventArgs e)
        {
            string po = urcombo.SelectedItem.ToString();
            switch(po)
            {
                case "Inventarna st":
                    po = "inv";
                    break;
                case "Naslov":
                    po = "nasl";
                    break;
                case "Avtor":
                    po = "avtor";
                    break;
                case "Leto":
                    po = "let";
                    break;
                case "Sections":
                    po = "sec";
                    break;
                case "Publisher":
                    po = "publ";
                    break;

            }

            if(ascbutton.Checked == true)
            {
                this.knjigegrid.Sort(this.knjigegrid.Columns[po], ListSortDirection.Ascending);

            }
            else if (descbutton.Checked == true)
            {
                this.knjigegrid.Sort(this.knjigegrid.Columns[po], ListSortDirection.Descending);
            }
            else
            {
                MessageBox.Show("Ni izbrana smer urejanja");
            }
        }

        private void poc_Click(object sender, EventArgs e)
        {
            polnjenje();
        }
    }
}
