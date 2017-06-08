using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8UzduotisKeliamiejiMetaiFor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paprastieji metai - 365 dienos
            // Keliamieji metai - 366 dienos, dalijasi be liekanos is 4;
            // Jei metai simtmeciai pvz 1600 ir dalus is 400, tai jie irgi keliamieji
            // Rasti visus keliamuosius metus nuo 0 iki 2017.

            Console.WriteLine("Keliamuju musu eros metu radimas");
            Console.WriteLine();
            Console.WriteLine("Keliamieji metai nuo 0 iki 2017 yra:");

            for (int i = 0; i <= 2017; i++)
            {
                if (i % 4 == 0)
                {
                    if (i % 10 == 0)
                    {
                        if (i % 100 == 0)
                        {
                            if (i % 400 == 0)
                                Console.WriteLine(i);
                        }
                        
                    }
                    else Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
