using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vraag4
{
    class Program
    {
        static Random Ei = new Random();
        static void Main(string[] args)
        {
            
                string[,] Veld = new string[10, 10];
                int probeX = 10, probeY = 10;
                int X,  Y;
                bool done = false;



                for (int i = 0; i < Veld.GetLength(0); i++)
                {
                    for (int j = 0; j < Veld.GetLength(1); j++)
                    {
                        Veld[i, j] = "-\t";

                    }
                }
                X = Ei.Next(10);
                Y = Ei.Next(10);
                while (!done)
                {
                    Console.WriteLine($"The Positie  X= :{X}");
                    Console.WriteLine($"The Positie  Y= :{Y}");
                    ShowVeld(Veld);
                    Console.WriteLine("Vind het paasei, geef een rij (0-9)");
                    probeX = int.Parse(Console.ReadLine());
                    Console.WriteLine("Give your guess on the Y (0-9)");
                    probeY = int.Parse(Console.ReadLine());
                    Veld[probeX, probeY] = "X";



                    if (probeX == X && probeY == Y)
                    {
                    Console.WriteLine("Je hebt het ei gevonden !");
                    //Console.WriteLine("Je hebt om te stoppen ?");
                    Console.WriteLine("Druk <Enter> om opnieuw te spelen ");
                    Console.WriteLine("Type E om af te sluiten ");

                    if (Console.ReadLine().ToUpper() == "E")



                        done = true; 

                    else
                        {

                            for (int i = 0; i < Veld.GetLength(0); i++)
                            {
                                for (int j = 0; j < Veld.GetLength(1); j++)
                                {
                                    Veld[i, j] = "-\t";
                                }
                            }
                            X = Ei.Next(10);
                            Y = Ei.Next(10);
                        }
                    }
                    Console.Clear();
                    if (X < probeX)
                        Console.WriteLine("The ei is more to the oosten");
                    else if (X > probeX)
                        Console.WriteLine("The ei is more to the westen");
                    else
                        Console.WriteLine($"The x guess is correct: {probeX}");
                    if (Y < probeY)
                        Console.WriteLine("The ei is more to the zuiden");
                    else if (Y > probeY)
                        Console.WriteLine("The ei is more to the norden");
                    else
                        Console.WriteLine($"The Y guess is correct: {probeY}");
                }
                Console.Clear();

            }

            private static void ShowVeld(String[,] grid)
            {
                for (int i = 0; i < grid.GetLength(0); i++)
                {
                    for (int j = 0; j < grid.GetLength(1); j++)
                    {
                        Console.Write($"{grid[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }

