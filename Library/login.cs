﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;
using System.Data.SQLite;

namespace Library
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void prijavaButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string geslo = gesloBox.Text;

            bool prijava = baza.Prijava(username, geslo);

            if (prijava==true)
            {
                Form mainform = new mainform();
                this.Hide();
                mainform.Show();
            }
            else
            {
                MessageBox.Show("fuck niggas");
            }
        }
    }
}
