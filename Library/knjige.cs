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
        public string Opomba;
        public int Status;

        public string Shop;
        public bool Lost;

        public knjige(int id, string n, int l, string a, string z, string s , int st)
        {
            inventarna_st = id;
            Naslov = n;
            Leto = l;
            Avtor = a;
            Zalozba = z;
            Section = s;
            Status = st;
        }

        public knjige(string naslov, string shop, string section, int leto, string avtor, string zaloznik, string opomba)
        {
            Naslov = naslov;
            Shop = shop;
            Section = section;
            Leto = leto;
            Avtor = avtor;
            Zalozba = zaloznik;
            Opomba = opomba;
        }


    }


}
