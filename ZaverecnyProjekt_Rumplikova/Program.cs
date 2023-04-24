using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjekt_Rumplikova
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Evidence pojištění";

            Evidence evidence = new Evidence();


            char volba = '0';
            while (volba != '4')


            {

                Console.WriteLine("\n---------------------------------");
                Console.WriteLine("Evidence pojištěných \n---------------------------------");


                Console.WriteLine("Vyberte si akci:");
                Console.WriteLine("1 - Přidat nového pojištěného");
                Console.WriteLine("2 - Vypsat všechny pojištěné");
                Console.WriteLine("3 - Vyhledat pojištěného");
                Console.WriteLine("4 - Konec");


                volba = Console.ReadKey().KeyChar;
                Console.WriteLine();


                switch (volba)
                {
                    case '1':
                        evidence.PridejZaznam();
                        break;
                    case '2':
                        evidence.VypisVse();
                        break;
                    case '3':
                        evidence.NajdiPojistence();
                        break;
                    case '4':
                        Console.WriteLine("Libovolnou klávesou ukončíte program");
                        break;
                    default:
                        Console.WriteLine("Neplatná volba - zadejte volbu znovu.");
                        break;


                }

            }

        }
    }
}
