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
    public partial class clandodajknjigo : Form
    {
        int id;
        public clandodajknjigo(int cid)
        {
            InitializeComponent();
            id = cid;
            polnjenje();
        }

        private void polnjenje()
        {
            List<knjige> knjiga = baza.IzpisKnjigNaVoljo(1);
            
            foreach (knjige x in knjiga)

            {
     
                ckgrid.Rows.Add(new object[] { x.inventarna_st, x.Naslov, x.Avtor, x.Leto, x.Section, x.Zalozba , "Izposodi"});

            }
        }

        private void nazajbutton_Click(object sender, EventArgs e)
        {
            clanipodatki cp = new clanipodatki(id);
            cp.Show();
            this.Close();
        }

        private void ckgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                int id_b = Convert.ToInt32(ckgrid.Rows[e.RowIndex].Cells[0].Value);
                bool ok = baza.RentABook(id, id_b, 0);
                if(ok)
                    MessageBox.Show("Uspešno izposodil knjigo");
                else
                    MessageBox.Show("Prislo je do napake");
                ckgrid.Rows.Clear();
                polnjenje();
            }
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            ckgrid.Rows.Clear();

            string searchtext = searchbar.Text;

            List<knjige> knigga = baza.SearchKnjig(searchtext);

            foreach (knjige x in knigga)

            {
                ckgrid.Rows.Add(new object[] { x.inventarna_st, x.Naslov, x.Avtor, x.Leto, x.Section, x.Zalozba, "Izposodi" });
            }
        }
    }
}
