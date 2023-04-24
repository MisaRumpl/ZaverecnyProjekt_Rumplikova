using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjekt_Rumplikova
{
    class Pojistenec
    {
        public string Jméno { get; set; }
        public string Příjmení { get; set; }
        public string Telefon { get; set; }
        public int Věk { get; set; }

        public Pojistenec(string jmeno, string prijmeni, string telefon, int vek)
        {
            Jméno = jmeno;
            Příjmení = prijmeni;
            Telefon = telefon;
            Věk = vek;
        }

        public override string ToString()
        {
            return Jméno + " " + Příjmení + " " + Telefon + " " + Věk;
        }

    }
}