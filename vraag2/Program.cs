using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vraag2Passwordgenerator
{
    class Program
    {
        //Vraag2

        static Random random = new Random();
        static void Main(string[] args)
        {
            string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";


            StringBuilder sb = new StringBuilder();

            Console.WriteLine(Password(chars, sb, 5));
            Console.ReadLine();

            Console.WriteLine("U kunt een ander passwoord gebruiken?  ");


        }
        static string Password(string chars, StringBuilder sb, int lengte)
        {

            for (int i = 0; i < lengte; i++)
            {
                sb.Append(chars[random.Next(chars.Length)]);
            }

            return sb.ToString();



        }
    }
}
