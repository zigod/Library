using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Users
    {
        public int id;
        public string name;
        public string surname;
        public string telephone;
        public string address;
        public string email;
        public string username;
        public string password;
        public string notes;


        public Users(string n,string sn,string tel,string nas, string em, string not)
        {
            name = n;
            surname = sn;
            telephone = tel;
            address = nas;
            email = em;
            notes = not;
        }

        public Users(int i, string n,string sn,string tel,string em)
        {
            id = i;
            name = n;
            surname = sn;
            telephone = tel;
            email = em;
        }

        public Users(int i, string n, string sn, string tel, string em, string us, string pass, string ada, string not) : this(i, n, sn, tel, em)
        {
            address = ada;
            username = us;
            password = pass;
            notes = not;
        }
    }
}
