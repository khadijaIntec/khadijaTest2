using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostNummer
{
    class Program
    {
        static void Main(string[] args)
        {
            //vraag 3

            Console.WriteLine("Geef de postCode in de Stad :");
            string Postnumer = new string('-', 20);
            Console.WriteLine(Postnumer);

            int[] postNummer = { 9300, 2000, 1000, 92000, 9000, 8500, 9700, 2300 };
            string[] NaamStad = { "Aalst", "Antwerpen", "Brussel", "Dendermond", " Gent", "Kortrijk", "Oudernaarde", "Turnhout" };

            int value = int.Parse(Console.ReadLine());
            int Pnummer = Array.IndexOf(postNummer, value);
            Console.WriteLine($" De Naamstad van die postNummer is  : {NaamStad[Pnummer]}");
        {
                
                   
            }

        }
    }
}
