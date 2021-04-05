using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class knjige
    {
        public int inventarna_st;
        public string Naslov;
        public int Leto;
        public string Avtor;
        public string Zalozba;
        public string Section;

        public int Status;

        public string Shop;
        public int Lost;
        public string notes;

        public knjige(int id, string n, int let, string a, string z, string s , int st)
        {
            inventarna_st = id;
            Naslov = n;
            Leto = let;
            Avtor = a;
            Zalozba = z;
            Section = s;
            Status = st;
        }

        public knjige(string sh, string not, int l, int id, string n, int let, string a, string z, string s, int st) : this(id,n,let,a,z,s,st)
        {
            Shop = sh;
            notes = not;
            Leto = l;
        }

    }


}
