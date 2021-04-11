using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Microsoft.Office.Interop;
using Excel = Microsoft.Office.Interop.Excel;


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
        
        private void dodajanjeTab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void zalozbaBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void oddelekComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pridobitevComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void opombeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void avtorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void letoTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void naslovKnjigeTextBox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void izpobutton_Click(object sender, EventArgs e)
        {
            knjigegrid.Rows.Clear();
            List<knjige> kn = baza.IzpisKnjigNaVoljo(0);
            foreach (knjige x in kn)

            {
                string stat = "";
                if (x.Status == 0)
                    stat = "Izposojeno";
                else
                    stat = "Prosto";

                knjigegrid.Rows.Add(new object[] { x.inventarna_st, x.Naslov, x.Avtor, x.Leto, x.Section, x.Zalozba, "Več", stat });

            }

            for (int i = 0; i < knjigegrid.Rows.Count; i++)
            {

                string stat = Convert.ToString(knjigegrid.Rows[i].Cells[7].Value);
                if (stat == "Izposojeno")
                    knjigegrid.Rows[i].Cells[7].Style.BackColor = Color.Red;
                else
                    knjigegrid.Rows[i].Cells[7].Style.BackColor = Color.Green;

            }

        }

        private void prostbutton_Click(object sender, EventArgs e)
        {
            knjigegrid.Rows.Clear();
            List<knjige> kn = baza.IzpisKnjigNaVoljo(1);
            foreach (knjige x in kn)

            {
                string stat = "";
                if (x.Status == 0)
                    stat = "Izposojeno";
                else
                    stat = "Prosto";

                knjigegrid.Rows.Add(new object[] { x.inventarna_st, x.Naslov, x.Avtor, x.Leto, x.Section, x.Zalozba, "Več", stat });

            }

            for (int i = 0; i < knjigegrid.Rows.Count; i++)
            {

                string stat = Convert.ToString(knjigegrid.Rows[i].Cells[7].Value);
                if (stat == "Izposojeno")
                    knjigegrid.Rows[i].Cells[7].Style.BackColor = Color.Red;
                else
                    knjigegrid.Rows[i].Cells[7].Style.BackColor = Color.Green;

            }
        }

        private void allizpis_Click(object sender, EventArgs e)
        {
            polnjenje();
        }

        private void statistika_Click(object sender, EventArgs e)
        {
            statistika sta = new statistika();
            sta.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Close();
        Excel.Application oXL;
        Excel._Workbook oWB;
        Excel._Worksheet oSheet;
        int naprej = 2;
        private void izvozButton_Click(object sender, EventArgs e)
        {
            oXL = new Excel.Application();
            oWB = (Excel.Workbook)oXL.Workbooks.Add();
            oSheet = (Excel._Worksheet)oWB.ActiveSheet;

            oSheet.Cells[1, 1] = "Naslov";
            oSheet.Cells[1, 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gray);
            oSheet.Cells[1, 2] = "Avtor";
            oSheet.Cells[1, 2].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gray);
            oSheet.Cells[1, 3] = "Leto";
            oSheet.Cells[1, 3].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gray);
            oSheet.Cells[1, 4] = "Oddelek";
            oSheet.Cells[1, 4].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gray);
            oSheet.Cells[1, 5] = "Založnik";
            oSheet.Cells[1, 5].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gray);
            oSheet.Cells[1, 6] = "Status";
            oSheet.Cells[1, 6].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gray);

            oSheet.get_Range("A1", "F1").Font.Bold = true;
            oSheet.get_Range("A1", "F1").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

            oSheet.Columns[1].ColumnWidth = 60;
            oSheet.Columns[2].ColumnWidth = 40;
            oSheet.Columns[3].ColumnWidth = 7;
            oSheet.Columns[4].ColumnWidth = 30;
            oSheet.Columns[5].ColumnWidth = 42;



            List<knjige> knigger = baza.izpisvsehknjig();

            foreach (knjige x in knigger)
            {
                //worksheet.Cells[i + 2, 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Green);
                oSheet.Cells[naprej, 1] = x.Naslov;
                oSheet.Cells[naprej, 2] = x.Avtor;
                oSheet.Cells[naprej, 3] = x.Leto;
                oSheet.Cells[naprej, 4] = x.Section;
                oSheet.Cells[naprej, 5] = x.Zalozba;
                if (x.Status == 0)
                {
                    oSheet.Cells[naprej, 6].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                }
                else
                {
                    oSheet.Cells[naprej, 6].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Green);
                }
                naprej++;
            }

            oWB.Application.ActiveWorkbook.SaveAs(@"C:\Users\Ziga\Desktop\Excel\" + izvozIme.Text + ".xlsx");

        }
    }
}
