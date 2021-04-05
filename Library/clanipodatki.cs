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
        public clanipodatki()
        {
            InitializeComponent();
        }

        private void nazajbutton_Click(object sender, EventArgs e)
        {
            main ma = new main();
            ma.Show(); 
            this.Close();
        }
    }
}
