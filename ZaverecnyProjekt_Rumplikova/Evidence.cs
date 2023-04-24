using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjekt_Rumplikova
{
 class Evidence
    {
        private Databaze databaze;

        public Evidence()
        {
            databaze = new Databaze();
        }

        private string ZjistiJmeno()
        {
            Console.WriteLine("Zadejte jméno:");
            string jmeno;
            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine()))
            {
                Console.WriteLine("Zadejte text znovu:");
            }
            return jmeno.ToLower().Trim();
        }


        private string ZjistiPrijmeni()
        {
            Console.WriteLine("Zadejte příjmení:");
            string prijmeni;
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()))
            {
                Console.WriteLine("Zadejte text znovu:");
            }
            return prijmeni.ToLower().Trim();
        }

        private string ZjistiTelefon()
        {
            Console.WriteLine("Zadejte telefonní číslo:");
            string telefon;
            while (string.IsNullOrWhiteSpace(telefon = Console.ReadLine()))
            {
                Console.WriteLine("Zadejte číslo znovu:");
            }
            return telefon.ToLower().Trim();
        }

        private int ZjistiVek()
        {
            Console.WriteLine("Zadejte věk:");
            int vek;
            while (!int.TryParse(Console.ReadLine(), out vek))
            {
                Console.WriteLine("Neplatný formát, zadejte číslo.");
            }
            return vek;
        }

        public void PridejZaznam()
        {
            Console.WriteLine();
            string jmeno = ZjistiJmeno();
            string prijmeni = ZjistiPrijmeni();
            string telefon = ZjistiTelefon();
            int vek = ZjistiVek();
            databaze.PridejPojistence(jmeno, prijmeni, telefon, vek);
            Console.WriteLine("Data byla uložena. Pokračujte libovolnou klávesou... ");
            Console.ReadKey();
                }

        public void VypisVse()
        {
            databaze.NajdiZaznamy();
            Console.WriteLine("Pokračuj libovolnou klávesou...");
        }

        public void NajdiPojistence()
        {
            string jmeno = ZjistiJmeno();
            string prijmeni = ZjistiPrijmeni();
            databaze.NajdiPodleJmena(jmeno, prijmeni);

            Console.WriteLine("Pokračujte libovolnou klávesou....");
        }
     }
   }

