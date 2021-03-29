using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Library
{
    class baza
    {
        public static SQLiteConnection connect()
        {
            SQLiteConnection con;
            con = new SQLiteConnection("data source = librarybaza.sqlite");
            return con;

        }
    }
}
