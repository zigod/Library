using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Users
    {
        public string name;
        public string surname;
        public string telephone;
        public string address;
        public string email;
        public string username;
        public string password;


        public Users(string n,string sn,string tel,string em)
        {
            name = n;
            surname = sn;
            telephone = tel;
            email = em;
        }
    }
}
