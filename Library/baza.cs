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
      
        public static knjige PodatkiOknjigi(int idk)
        {
            knjige kn;
            SQLiteConnection con = connect();
            con.Open();


            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "SELECT k.id,k.title,k.shop,k.notes,s.name,k.year,k.author,k.publisher,k.lost FROM books k INNER JOIN sections s ON s.id = k.section_id WHERE k.id = " + idk + ";";
                SQLiteDataReader read = com.ExecuteReader();
                read.Read();
                int it = read.GetInt32(0);
                string naslov = read.GetString(1);
                int shop = read.GetInt32(2);
                string opombe = read.GetString(3);
                string section = read.GetString(4);
                int leto = read.GetInt32(5);
                string avtor = read.GetString(6);
                string publisher = read.GetString(7);
                int lost = read.GetInt32(8);


                string nacinpridobitve = "";
                switch(shop)
                {
                    case 0:
                        nacinpridobitve = "Nakup";
                        break;
                    case 1:
                        nacinpridobitve = "Darilo";
                        break;
                    case 2:
                        nacinpridobitve = "Ostalo";
                        break;

                }
                int st = 0;
                kn = new knjige(nacinpridobitve, opombe, lost, it, naslov, leto, avtor, publisher, section, st);




                com.Dispose();
                con.Close();



            }
            return kn;
        }
        public static void UpdateUporabnika(Users user, int idu)
        {
            SQLiteConnection con = connect();
            con.Open();


            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "UPDATE users SET name = '" + user.name + "',surname = '" + user.surname + "',tel = '" + user.telephone + "',address = '" + user.address + "',email = '" + user.email + "',notes = '" + user.notes + "' WHERE id = " + idu + ";";
                com.ExecuteNonQuery();
               



                com.Dispose();
                con.Close();



            }
        }
        public static bool PreverjanjeUporabnika(string email,string telefon,int idu)
        {
            bool ok = true;
            SQLiteConnection con = connect();
            con.Open();


            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "SELECT id FROM USERS WHERE tel = '" + telefon + "' OR email = '" + email + "';";
                SQLiteDataReader read = com.ExecuteReader();
                read.Read();
                int id = read.GetInt32(0);
                if(id > 0 && idu != id)
                {
                    ok = false;
                }
                



                com.Dispose();
                con.Close();

              

            }
            return ok;
        }
        public static Users IzpisVsePodatkeOUser(int idu)
        {

            Users uporabni;
            SQLiteConnection con = connect();
            con.Open();


            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "SELECT * FROM USERS WHERE id = " + idu + ";";
                SQLiteDataReader read = com.ExecuteReader();
                read.Read();

            
                string name = read.GetString(1);
                string surname = read.GetString(2);
                string telephone = read.GetString(3);
                string address = read.GetString(4);
                string email = read.GetString(5);
                
                string notes = read.GetString(8);


                Users uporabnik = new Users(idu, name, surname, telephone, email, address, notes);

                uporabni = uporabnik;


                com.Dispose();
                con.Close();

                return uporabni;

            }
        }

        public static List<Users>IzpisUsers()
        {
            List<Users> us = new List<Users>();
            SQLiteConnection con = connect();
            con.Open();

            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "SELECT name,surname,tel,email,id FROM users;";
                SQLiteDataReader read = com.ExecuteReader();
                while (read.Read())
                {

                    string name = read.GetString(0);
                    string surname = read.GetString(1);
                    string tel = read.GetString(2);
                    string email = read.GetString(3);
                    int id = read.GetInt32(4);
                 
                    Users user = new Users(id,name,surname,tel,email);


                    us.Add(user);

                }
                com.Dispose();
                con.Close();
                return us;

            }
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

        public static void DodajClana(string ime, string priimek, string tel, string naslov, string email, string opombe)
        {
            SQLiteConnection con = connect();

            con.Open();
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "INSERT INTO users(name , surname, tel, address, email, notes) VALUES('" + ime + "','" + priimek + "','" + tel + "','" + naslov + "','" + email + "','" + opombe + "');";
                com.ExecuteNonQuery();
            }
            con.Close();
        }

        public static void DodajKnjigo(string naslov, string shop, string section, int leto, string avtor, string zaloznik, string opomba)
        {
            SQLiteConnection con = connect();
            int idOddelka = 0;
            con.Open();
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "SELECT id FROM sections WHERE name='" + section + "';";
                SQLiteDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    idOddelka = read.GetInt32(0);
                }
            }
            con.Close();

            con.Open();
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "INSERT INTO books(title, shop, notes, section_id, year, author, publisher) VALUES('" + naslov + "', '" + shop + "', '" + opomba + "', '" + idOddelka + "', '" + leto + "', '" + avtor + "', '" + zaloznik + "');";
                com.ExecuteNonQuery();
            }
            con.Close();
        }

        public static List<string> SelectSections()
        {
            List<string> sections = new List<string>();
            SQLiteConnection con = connect();
            con.Open();
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "SELECT name FROM sections ;";
                SQLiteDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    string imeSekcije = read.GetString(0);

                    sections.Add(imeSekcije);
                }
            }
            con.Close();
            return sections;
        }
    }
}
