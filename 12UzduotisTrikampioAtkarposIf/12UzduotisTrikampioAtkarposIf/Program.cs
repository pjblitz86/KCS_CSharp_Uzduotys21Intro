using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12UzduotisTrikampioAtkarposIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRIKAMPIO ATKARPOS");
            Console.WriteLine();
            Console.Write("Iveskite 1a atkarpa: ");
            double atkarpa1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Iveskite 2a atkarpa: ");
            double atkarpa2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Iveskite 3ia atkarpa: ");
            double atkarpa3 = Convert.ToDouble(Console.ReadLine());

            if ((atkarpa1 + atkarpa2 > atkarpa3) &&
                (atkarpa2 + atkarpa3 > atkarpa1) &&
                (atkarpa1 + atkarpa3 > atkarpa2))
            {
                if (atkarpa1 == atkarpa2 && atkarpa2 == atkarpa3 && atkarpa1 == atkarpa3)
                {
                    Console.WriteLine("Trikampis yra lygiakrastis");
                }
                else if ((atkarpa1*atkarpa1+atkarpa2*atkarpa2==atkarpa3*atkarpa3) ||
                    (atkarpa2 * atkarpa2 + atkarpa3 * atkarpa3 == atkarpa1 * atkarpa1) ||
                    (atkarpa1 * atkarpa1 + atkarpa3 * atkarpa3 == atkarpa2 * atkarpa2))
                {
                    Console.WriteLine("Trikampis yra statusis");
                }
                else if (atkarpa1 == atkarpa2 || atkarpa1 == atkarpa3 || atkarpa2 == atkarpa3)
                {
                    Console.WriteLine("Trikampis yra lygiasonis");
                }
                else if (atkarpa1 != atkarpa2 && atkarpa2 != atkarpa3 && atkarpa1 != atkarpa3)
                {
                    Console.WriteLine("Trikampis yra ivairiakrastis");
                }
            }

            else
            {
                Console.WriteLine("Trikampio sudaryti negalima");
            }
            Console.ReadKey();
        }
    }
}
