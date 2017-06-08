using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4UzduotisGraza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GRAZOS ATIDAVIMAS");
            Console.WriteLine();
            Console.WriteLine("Iveskite sveika skaiciu, graza eur iki 500 eur imtinai: ");
            int graza = Convert.ToInt32(Console.ReadLine());
            int graza100 = 100;
            int graza50 = 50;
            int graza20 = 20;
            int graza10 = 10;
            int graza5 = 5;
            int graza2 = 2;
            int graza1 = 1;

            // logiskai mastant graza bus <=500 be kablelio t.y. sveikas vienzenklis, 2zenklis ar 3zenklis skaicius

            // jei trizenklis
            if (graza >= 100 && graza <= 500)
            {
                int graza3zenklisSkaitmuo1 = graza / 100;
                int graza3zenklisSkaitmuo2 = graza % 100 / 10;
                int graza3zenklisSkaitmuo3 = graza % 10;

                // 3zenklio 1 skaitmuo
                switch (graza3zenklisSkaitmuo1)
                {
                    case 1:
                        Console.WriteLine("{0} * {1} = {2}", 1, graza100, 1 * graza100);
                        break;
                    case 2:
                        Console.WriteLine("{0} * {1} = {2}", 2, graza100, 2 * graza100);
                        break;
                    case 3:
                        Console.WriteLine("{0} * {1} = {2}", 3, graza100, 3 * graza100);
                        break;
                    case 4:
                        Console.WriteLine("{0} * {1} = {2}", 4, graza100, 4 * graza100);
                        break;
                    case 5:
                        Console.WriteLine("{0} * {1} = {2}", 5, graza100, 5 * graza100);
                        break;
                }
                // 3zenklio 2 skaitmuo
                switch (graza3zenklisSkaitmuo2)
                {
                    case 1:
                        Console.WriteLine(graza10);
                        break;
                    case 2:
                        Console.WriteLine(graza20);
                        break;
                    case 3:
                        Console.WriteLine("{0} + {1}", graza20, graza10);
                        break;
                    case 4:
                        Console.WriteLine("{0} + {1}", graza20, graza20);
                        break;
                    case 5:
                        Console.WriteLine(graza50);
                        break;
                    case 6:
                        Console.WriteLine("{0} + {1}", graza50, graza10);
                        break;
                    case 7:
                        Console.WriteLine("{0} + {1}", graza50, graza20);
                        break;
                    case 8:
                        Console.WriteLine("{0} + {1} + {2}", graza50, graza20, graza10);
                        break;
                    case 9:
                        Console.WriteLine("{0} + {1} + {2}", graza50, graza20, graza20);
                        break;
                }
                // 3zenklio 3 skaitmuo
                switch (graza3zenklisSkaitmuo3)
                {
                    case 1:
                        Console.WriteLine(graza1);
                        break;
                    case 2:
                        Console.WriteLine(graza2);
                        break;
                    case 3:
                        Console.WriteLine("{0} + {1}", graza2, graza1);
                        break;
                    case 4:
                        Console.WriteLine("{0} + {1}", graza2, graza2);
                        break;
                    case 5:
                        Console.WriteLine(graza5);
                        break;
                    case 6:
                        Console.WriteLine("{0} + {1}", graza5, graza1);
                        break;
                    case 7:
                        Console.WriteLine("{0} + {1}", graza5, graza2);
                        break;
                    case 8:
                        Console.WriteLine("{0} + {1} + {2}", graza5, graza2, graza1);
                        break;
                    case 9:
                        Console.WriteLine("{0} + {1} + {2}", graza5, graza2, graza2);
                        break;
                }
            }

            // jei 2zenklis
            else if (graza >= 10 && graza <= 99)
            {
                int graza2zenklisSkaitmuo1 = graza / 10;
                int graza2zenklisSkaitmuo2 = graza % 10;

                // 2zenklio 1 skaitmuo
                switch (graza2zenklisSkaitmuo1)
                {
                    case 1:
                        Console.WriteLine(graza10);
                        break;
                    case 2:
                        Console.WriteLine(graza20);
                        break;
                    case 3:
                        Console.WriteLine("{0} + {1}", graza20, graza10);
                        break;
                    case 4:
                        Console.WriteLine("{0} + {1}", graza20, graza20);
                        break;
                    case 5:
                        Console.WriteLine(graza50);
                        break;
                    case 6:
                        Console.WriteLine("{0} + {1}", graza50, graza10);
                        break;
                    case 7:
                        Console.WriteLine("{0} + {1}", graza50, graza20);
                        break;
                    case 8:
                        Console.WriteLine("{0} + {1} + {2}", graza50, graza20, graza10);
                        break;
                    case 9:
                        Console.WriteLine("{0} + {1} + {2}", graza50, graza20, graza20);
                        break;
                }
                // 2zenklio 2 skaitmuo
                switch (graza2zenklisSkaitmuo2)
                {
                    case 1:
                        Console.WriteLine(graza1);
                        break;
                    case 2:
                        Console.WriteLine(graza2);
                        break;
                    case 3:
                        Console.WriteLine("{0} + {1}", graza2, graza1);
                        break;
                    case 4:
                        Console.WriteLine("{0} + {1}", graza2, graza2);
                        break;
                    case 5:
                        Console.WriteLine(graza5);
                        break;
                    case 6:
                        Console.WriteLine("{0} + {1}", graza5, graza1);
                        break;
                    case 7:
                        Console.WriteLine("{0} + {1}", graza5, graza2);
                        break;
                    case 8:
                        Console.WriteLine("{0} + {1} + {2}", graza5, graza2, graza1);
                        break;
                    case 9:
                        Console.WriteLine("{0} + {1} + {2}", graza5, graza2, graza2);
                        break;
                }
            }

            // 1 zenklis
            else if (graza >=1 && graza <=9)
            {
                int graza1zenklisSkaitmuo = graza % 10;

                // 1zenklio skaitmuo
                switch (graza1zenklisSkaitmuo)
                {
                    case 1:
                        Console.WriteLine(graza1);
                        break;
                    case 2:
                        Console.WriteLine(graza2);
                        break;
                    case 3:
                        Console.WriteLine("{0} + {1}", graza2, graza1);
                        break;
                    case 4:
                        Console.WriteLine("{0} + {1}", graza2, graza2);
                        break;
                    case 5:
                        Console.WriteLine(graza5);
                        break;
                    case 6:
                        Console.WriteLine("{0} + {1}", graza5, graza1);
                        break;
                    case 7:
                        Console.WriteLine("{0} + {1}", graza5, graza2);
                        break;
                    case 8:
                        Console.WriteLine("{0} + {1} + {2}", graza5, graza2, graza1);
                        break;
                    case 9:
                        Console.WriteLine("{0} + {1} + {2}", graza5, graza2, graza2);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Graza ivesta >500 arba blogai ivesta");
            }
            Console.ReadKey();
        }

        }
    }

