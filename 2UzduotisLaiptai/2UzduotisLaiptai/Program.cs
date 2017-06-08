using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2UzduotisLaiptai
{
    class Program
    {
        // laiptai principas, priklausomai kiek iveda eiluciu
        //  #
        // ##
        //###
        static void Main(string[] args)
        {
            Console.WriteLine("LAIPTAI");
            Console.WriteLine("#######");
            Console.WriteLine();
            Console.WriteLine("Iveskite kiek norite eiluciu ir as jums atspausdinsiu laiptus");
            int kiekEiluciu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // pagal uzduoti
            for (int i = kiekEiluciu; i >= 1; i--)
            {
                for (int j = 1; j <= kiekEiluciu; j++)
                {
                    if (i > j)
                        Console.Write(" ");
                    else
                        Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // paprasti laiptai is kaires i desine
            for (int eilute = 1; eilute <= kiekEiluciu; eilute++)
            {
                for (int stulpelis = 1; stulpelis <= eilute; stulpelis++)
                {
                        Console.Write("#"); 
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            
            // sudetingesnis is desines i kaire
            for (int eilute = kiekEiluciu ; eilute >= 1; eilute--)
            {
                for (int stulpelis = 1; stulpelis <= eilute; stulpelis++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

            
        }
    }
}
