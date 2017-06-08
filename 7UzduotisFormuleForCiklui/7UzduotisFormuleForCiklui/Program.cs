using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7UzduotisFormuleForCiklui
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaip kinta y priklausomai nuo x");
            Console.WriteLine("*******************************");
            Console.WriteLine();

            for (int x = -10; x <= 10; x++)
            {
                int y = 7 * x * x + 5 * x - 3;
                Console.WriteLine("x={0} \t y={1}", x, y);
            }
            Console.ReadKey();
        }
    }
}
