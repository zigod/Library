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
    public partial class knjigaClani : Form
    {
        int idu;
        public knjigaClani(int id)
        {
            InitializeComponent();
            idu = id;
            polnjenje();
        }

        private void polnjenje()
        {
            List<knjige> knjiga = baza.IzpisIzposojenih(idu);
            foreach (knjige x in knjiga)
            {
                vrnitevGrid.Rows.Add(new object[] { x.inventarna_st, x.Naslov, x.Avtor, x.Leto, x.Section, x.Zalozba, "Več" });
            }

        }
    }
}
