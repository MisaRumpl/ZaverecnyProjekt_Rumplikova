using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZaverecnyProjekt_Rumplikova;

namespace ZaverecnyProjekt_Rumplikova
{
     class Databaze
    {
        private List<Pojistenec> pojistenci;

        public Databaze()
        {
            pojistenci = new List<Pojistenec>();
        }

        public void PridejPojistence(string jmeno, string prijmeni, string telefon, int vek)
        {
            pojistenci.Add(new Pojistenec(jmeno, prijmeni, telefon, vek));
        }

        public void NajdiZaznamy()
        {
            foreach (Pojistenec pojistenec in pojistenci)
            {
                Console.WriteLine(pojistenec);
            }
        }

        public void NajdiPodleJmena(string jmeno, string prijmeni)
        {
            foreach (Pojistenec pojistenec in pojistenci)
            {
                if (pojistenec.Jméno == jmeno && pojistenec.Příjmení == prijmeni)
                {
                    Console.WriteLine("Nalezený údaj:");
                    Console.WriteLine(pojistenec);
                }
                else
                {
                    Console.WriteLine("Nenalezeno");
                }
            }
        }
    }
}

