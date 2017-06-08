using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5UzduotisSviesoforas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sviesoforo spalva pagal minutes valandoje");
            Console.WriteLine();
            Console.WriteLine("Iveskite minute nuo 0 iki 59");
            int minute = Convert.ToInt32(Console.ReadLine());

            int minuteSkaitmuo2 = minute % 10;

            if(minuteSkaitmuo2 >0 && minuteSkaitmuo2 <= 3)
            {
                Console.WriteLine("Dega zalia sviesa");
                if(minuteSkaitmuo2==3)
                {
                    Console.WriteLine("Tuoj uzsidegs raudona");
                }
            }
            else if (minuteSkaitmuo2 > 3 && minuteSkaitmuo2 <= 5)
            {
                Console.WriteLine("Dega raudona sviesa");
                if(minuteSkaitmuo2 == 5)
                {
                    Console.WriteLine("Tuoj uzsidegs zalia"); 
                }
            }
            else if (minuteSkaitmuo2 > 5 && minuteSkaitmuo2 <= 8)
            {
                Console.WriteLine("Dega zalia sviesa");
                if (minuteSkaitmuo2 == 8)
                {
                    Console.WriteLine("Tuoj uzsidegs raudona");
                }
            }
            else if (minuteSkaitmuo2 > 8)
            {
                Console.WriteLine("Dega raudona sviesa");
            }
            else if (minuteSkaitmuo2 == 0)
            {
                Console.WriteLine("Dega raudona\nTuoj uzsidegs zalia");
            }
            else
            {
                Console.WriteLine("Blogai ivestos minutes");
            }
            Console.ReadKey();

        }
    }
}
