using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14UzduotisGreitpyragisSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GREITPYRAGIS");
            Console.WriteLine();

            Console.WriteLine("Pasirinkite kokio greitpyragio noresite:\n"+
                                "1 - su obuoliais\n" +
                                "2 - su melynemis\n" +
                                "3 - su juodaisiais serbentais\n" + 
                                "4 - su slyvomis");

            int pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:
                    Console.WriteLine("Greitpyragis su obuoliais labiausiai patiks mamai ir dukrai");
                    break;
                case 2:
                    Console.WriteLine("Greitpyragis su melynemis labiausiai patiks mamai ir dukrai");
                    break;
                case 3:
                    Console.WriteLine("Greitpyragis su juodaisiais serbentais labiausiai patiks tevui ir sunui");
                    break;
                case 4:
                    Console.WriteLine("Greitpyragis su slyvomis labiausiai patiks tevui ir sunui");
                    break;
                default:
                    Console.WriteLine("Blogai ivestas pasirinkimas");
                    break;
            }
            Console.ReadKey();
        }
    }
}
