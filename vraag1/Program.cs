using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestKhadija9_11_20
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Vraag 1 : 
            Console.WriteLine("Lees een bedrag in van een Factuur   : ");
            double amount = 0;
            double discount = 0;
            double enter = int.Parse(Console.ReadLine());

            if (enter > 5000)
            {
                discount = enter * 0.5;
                amount = enter - discount;
                Console.WriteLine("Welcome u krijgt 5% korting . ");
            }
            else
            {
                amount = enter;

            }
            Console.WriteLine(amount);


            if (enter < 5000)
            {

                Console.WriteLine("Welcome u krijgt geen korting . ");
            }
            else
            {
                amount = enter;
            }
        }
    }
}
