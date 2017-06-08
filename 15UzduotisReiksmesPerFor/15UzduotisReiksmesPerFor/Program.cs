using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15UzduotisReiksmesPerFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("X reiksmes istatymas i formule per for cikla ir y paskaiciavimas");
            Console.WriteLine();

            for (int x = -5; x <= 5; x++)
            {
                double y = Math.Sqrt(x * x + 3 * x + 5);
                Console.WriteLine("Kai x = {0}\t y = {1:0.0000}", x, y);
            }
            Console.ReadKey();
        }
    }
}
