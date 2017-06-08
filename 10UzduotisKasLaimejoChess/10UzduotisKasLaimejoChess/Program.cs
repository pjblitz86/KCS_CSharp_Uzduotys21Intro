using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10UzduotisKasLaimejoChess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kas laimejo sachmatu maca?");
            Console.WriteLine();
            Console.Write("Iveskite kiek tasku surinko Jonas: ");
            int JonoTaskai = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite kiek tasku surinko Povilas: ");
            int PoviloTaskai = Convert.ToInt32(Console.ReadLine());

            if (JonoTaskai > PoviloTaskai)
            {
                Console.WriteLine("Maca laimejo Jonas rezultatu {0}:{1}", JonoTaskai, PoviloTaskai);
            }
            else if (PoviloTaskai > JonoTaskai)
            {
                Console.WriteLine("Maca laimejo Povilas rezultatu {0}:{1}", PoviloTaskai, JonoTaskai);
            }
            else if (PoviloTaskai == JonoTaskai)
            {
                Console.WriteLine("Jono ir Povilo macas baigesi lygiosiomis rezultatu {0}:{1}"
                                    , JonoTaskai, PoviloTaskai);
            }
            else
                Console.WriteLine("KLAIDA: kazka blogai ivedete");
            Console.ReadKey();
        }
        
    }
}
