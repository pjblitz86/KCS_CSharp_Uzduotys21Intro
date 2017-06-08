using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9UzduotisPalukanos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palukanos per N metu");
            Console.WriteLine();

            Console.Write("Iveskite metu skaiciu pradedant nuo 1: ");
            int metai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("KASMETINE ATASKAITA");
            double indelis = 100;
            double palukanuNorma = 0.04;

            if (metai >=1)
            {
                for (int i = 1; i <= metai; i++)
                {
                    // naudojau sudetiniu palukanu formule
                    double likutisBanke = (double) (indelis * Math.Pow((1 + palukanuNorma), i));
                    Console.WriteLine("{0} metai, likutis banke {1:0.00}Lt", i, likutisBanke);
                }
            }
            else
            {
                Console.WriteLine("Blogai ivedete metus. Turi buti sveiki skaiciai ir >=1");
            }
            Console.ReadKey();
        }
    }
}
