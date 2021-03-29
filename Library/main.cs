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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void polnjenje()
        {
            List<knjige> lol = baza.izpisvsehknjig();
            foreach (knjige x in lol)
            {
                dataGridView1.Rows.Add(new object[] { x.inventarna_st,x.Naslov,x.Avtor,x.Leto,x.Section,x.Zalozba });
            }
        }
    }
}
