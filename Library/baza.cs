using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Library
{
    public class baza
    {
        public static SQLiteConnection connect()
        {
            SQLiteConnection con;
            con = new SQLiteConnection("data source = librarybaza.sqlite");
            return con;

        }

        public static bool Prijava(string username, string password)
        {
            SQLiteConnection con = connect();

            con.Open();
            bool preveritev = false;
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "SELECT username FROM users WHERE (username='" + username + "') AND (password='" + password + "');";

                SQLiteDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    string user = read.GetString(0);

                    if (user != null)
                    {
                        preveritev = true;
                    }
                }
                com.Dispose();
            }
            return preveritev;
        }

        public static List<knjige>izpisvsehknjig()
        {
            List<knjige> knj = new List<knjige>();
            SQLiteConnection con = connect();
            con.Open();

            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "SELECT b.id,b.title,b.year,b.author,b.publisher,s.name FROM books b INNER JOIN sections s ON b.section_id = s.id ORDER BY b.id;";
                SQLiteDataReader read = com.ExecuteReader();
                while (read.Read())
                {

                    int id = read.GetInt32(0);
                    string naslov = read.GetString(1);
                    int leto = read.GetInt32(2);
                    string avtor = read.GetString(3);
                    string publisher = read.GetString(4);
                    string section = read.GetString(5);
                    int state = 0; //read.GetInt32(6);
                    knjige knjiga = new knjige(id, naslov, leto, avtor, publisher, section,state);


                    knj.Add(knjiga);

                }
                com.Dispose();
                con.Close();
                return knj;

            }
        }
    }
}
