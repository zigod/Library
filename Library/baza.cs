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
            string cs = @"URI=file:C:\Users\Ziga\source\repos\Library\Library\bin\Debug\librarybaza.sqlite";
            con = new SQLiteConnection(cs);
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


        
    }
}
    