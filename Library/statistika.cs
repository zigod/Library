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
    public partial class statistika : Form
    {
        public statistika()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rezbutton_Click(object sender, EventArgs e)
        {
            rezultatlabel.Text = "Število izposojenih knjig: ";

            DateTime zac = dateTimePicker1.Value.Date;
            DateTime kon = dateTimePicker2.Value.Date;

            string zacdat = zac.ToString("dd/MM/yyyy");
            string kondat = kon.ToString("dd/MM/yyyy");

            int frek = baza.frekvenca(zacdat, kondat);
            rezultatlabel.Text += frek.ToString();
        }

      
    }
}
