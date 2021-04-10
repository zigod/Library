using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

namespace Library
{
    public partial class spremeniStatus : Form
    {
        int id_b;
        public spremeniStatus(int idk)
        {
            InitializeComponent();
            id_b = idk;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            usersGridView.Rows.Clear();

            string search = iskanjeTextBox.Text;

            List<Users> user = baza.Search(search);

            foreach (Users x in user)
            {
                usersGridView.Rows.Add(new object[] { x.name, x.surname, x.telephone, x.email, "Izposodi", x.id });
            }

        }

        private void usersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 4)
            {
                int id_u = Convert.ToInt32(usersGridView.Rows[e.RowIndex].Cells[5].Value);

                bool neki = baza.RentABook(id_u, id_b);

                if (neki)
                {
                    MessageBox.Show("Knjiga uspešno dodana!");
                }
            }
        }
    }
}
