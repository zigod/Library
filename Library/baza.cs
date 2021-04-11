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
        public static List<knjige> SearchKnjig(string src)
        {
            SQLiteConnection con = connect();
            List<knjige> searchedbooks = new List<knjige>();
            con.Open();
            src = src.ToLower();
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "SELECT b.id,b.title,b.year,b.author,b.publisher,s.name,b.current_state FROM books b INNER JOIN sections s ON b.section_id = s.id WHERE LOWER(b.title) LIKE '%" + src + "%' OR b.year LIKE '%" + src + "%' OR LOWER(b.author) LIKE '%" + src + "%' OR LOWER(b.publisher) LIKE '%" + src + "%' OR LOWER(s.name) LIKE '%" + src + "%' ORDER BY b.id;";
                SQLiteDataReader read = com.ExecuteReader();
                if (read.HasRows == true)
                {
                    while (read.Read())
                    {
                        int id = read.GetInt32(0);
                        string naslov = read.GetString(1);
                        int leto = read.GetInt32(2);
                        string avtor = read.GetString(3);
                        string publisher = read.GetString(4);
                        string section = read.GetString(5);
                        int state = read.GetInt32(6);
                        knjige knjiga = new knjige(id, naslov, leto, avtor, publisher, section, state);
                        searchedbooks.Add(knjiga);
                    }
                }
                else
                {

                }
            }
            con.Dispose();
            return searchedbooks;
        }
      
        public static knjige PodatkiOknjigi(int idk)
        {
            knjige kn;
            SQLiteConnection con = connect();
            con.Open();


            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "SELECT k.id,k.title,k.shop,k.notes,s.name,k.year,k.author,k.publisher,k.lost,k.current_state FROM books k INNER JOIN sections s ON s.id = k.section_id WHERE k.id = " + idk + ";";
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
                int current_state = read.GetInt32(9);
               


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
                kn = new knjige(current_state,nacinpridobitve, opombe, lost, it, naslov, leto, avtor, publisher, section, st);




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
                com.CommandText = "SELECT b.id,b.title,b.year,b.author,b.publisher,s.name,b.current_state FROM books b INNER JOIN sections s ON b.section_id = s.id ORDER BY b.id;";
                SQLiteDataReader read = com.ExecuteReader();
                while (read.Read())
                {

                    int id = read.GetInt32(0);
                    string naslov = read.GetString(1);
                    int leto = read.GetInt32(2);
                    string avtor = read.GetString(3);
                    string publisher = read.GetString(4);
                    string section = read.GetString(5);
                    int state = read.GetInt32(6);
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

        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static List<Users> Search(string text)
        {
            text = text.ToLower();
            List<Users> userji = new List<Users>();
            SQLiteConnection con = connect();
            con.Open();
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "SELECT name, surname, tel, email, id FROM users WHERE (LOWER(name) LIKE '%" + text + "%') OR (LOWER(surname) LIKE '%" + text + "%') OR (LOWER(email) LIKE '%" + text + "%');";
                SQLiteDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    string ime = read.GetString(0);
                    string priimek = read.GetString(1);
                    string telefon = read.GetString(2);
                    string email = read.GetString(3);
                    int id = read.GetInt32(4);

                    Users user = new Users(id, ime, priimek, telefon, email);

                    userji.Add(user);
                }
            }
            con.Close();
            return userji;
        }
        
        public static bool VrniKnjigoNouid(int id_b)
        {
            DateTime date = DateTime.Now;
            string dejt = date.ToString();

            bool preveritev;

            SQLiteConnection con = connect();
            con.Open();
            try
            {
                using (SQLiteCommand com = new SQLiteCommand(con))
                {

                    com.CommandText = "UPDATE rents SET state = 1, date = '" + dejt + "' WHERE book_id = " + id_b + ";";
                    com.ExecuteNonQuery();

                    preveritev = true;
                }

            }
            catch
            {
                preveritev = false;
            }

            if (preveritev)
            {
                using (SQLiteCommand command = new SQLiteCommand(con))
                {
                    command.CommandText = "UPDATE books SET current_state = 1 WHERE id = " + id_b + ";";
                    command.ExecuteNonQuery();

                    preveritev = true;
                }
            }
            con.Close();

            return preveritev;
        }


        public static bool RentABook(int id_u, int id_b, int type)

        {
            DateTime date = DateTime.Now;
            string dejt = date.ToString();

            bool preveritev;

            SQLiteConnection con = connect();
            con.Open();
            try
            {
                using (SQLiteCommand com = new SQLiteCommand(con))
                {
                    if (type == 0)
                        com.CommandText = "INSERT INTO rents(user_id, book_id, state, date) VALUES(" + id_u + "," + id_b + "," + type + ",'" + dejt + "');";
                    else
                        com.CommandText = "UPDATE rents SET state = 1, date = '" + dejt + "' WHERE user_id = " + id_u + " AND book_id = " + id_b + ";";

                    com.ExecuteNonQuery();

                    preveritev = true;
                }

            }
            catch
            {
                preveritev = false;
            }


            if (preveritev)
            {
                using (SQLiteCommand command = new SQLiteCommand(con))
                {
                    command.CommandText = "UPDATE books SET current_state = " + type + " WHERE id = " + id_b + ";";
                    command.ExecuteNonQuery();

                    preveritev = true;
                }
            }
            con.Close();

            return preveritev;
        }

        public static List<knjige> IzpisKnjigNaVoljo(int status)
        {
            List<knjige> knjige = new List<knjige>();
            SQLiteConnection con = connect();
            con.Open();
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
              
                com.CommandText = "SELECT b.id,b.title,b.year,b.author,b.publisher,s.name,b.current_state FROM books b INNER JOIN sections s ON b.section_id = s.id WHERE current_state = " + status +" ORDER BY b.id;";
            

                SQLiteDataReader read = com.ExecuteReader();
                while (read.Read())
                {

                    int id = read.GetInt32(0);
                    string naslov = read.GetString(1);
                    int leto = read.GetInt32(2);
                    string avtor = read.GetString(3);
                    string publisher = read.GetString(4);
                    string section = read.GetString(5);
                    int state = read.GetInt32(6);
                    knjige knjiga = new knjige(id, naslov, leto, avtor, publisher, section, state);


                    knjige.Add(knjiga);

                }
                com.Dispose();
                con.Close();
                return knjige;

            }
         
        }

        public static List<knjige> IzpisIzposojenih(int id_u)
        {
            List<knjige> knjige = new List<knjige>();
            SQLiteConnection con = connect();
            con.Open();
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "SELECT b.title, b.author, b.year, s.name, b.id FROM books b INNER JOIN sections s ON s.id=b.section_id INNER JOIN rents r ON r.book_id=b.id  WHERE (b.current_state=0) AND (r.user_id='" + id_u + "');";
                SQLiteDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    string naslov = read.GetString(0);
                    string avtor = read.GetString(1);
                    int leto = read.GetInt32(2);
                    string oddelek = read.GetString(3);
                    int id = read.GetInt32(4);

                    knjige knjiga = new knjige(naslov, avtor, leto, oddelek, id);

                    knjige.Add(knjiga);
                }
            }
            con.Close();
            return knjige;
        }

        public static int frekvenca(string zac, string kon)
        {
            int frek = 0;
            SQLiteConnection con = connect();
            con.Open();
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "SELECT count(*) FROM rents WHERE date BETWEEN '" + zac + "' AND '" + kon + "';";
                SQLiteDataReader read = com.ExecuteReader();
                read.Read();
                frek = read.GetInt32(0);


            }
            con.Close();
            return frek;
        }

        public static List<string> TopUporabniki(string zac, string kon)
        {
            List<string> toplist = new List<string>();
            SQLiteConnection con = connect();
            con.Open();
            using(SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "SELECT count(*),u.name,u.surname FROM users u INNER JOIN rents r ON r.user_id = u.id  WHERE r.date BETWEEN '" + zac + "' AND '" + kon + "' GROUP BY u.name,u.surname ORDER BY count(*)  DESC LIMIT 10;";
                SQLiteDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    toplist.Add(read.GetString(1) + " " + read.GetString(2));
                }
            }
            con.Close();
            return toplist;
        }
    }
}
