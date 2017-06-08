using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13UzduotisDezuciuTilpimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ar dezutes telpa viena kitoje? Dezutes galima vartyti");
            Console.WriteLine();
            Console.WriteLine("Dezuciu matmenys sveikieji skaiciai nuo 1 iki 100 imtinai");

            Console.WriteLine("Iveskite A dezutes matmenis ilgi, ploti, auksti: ");
            int ilgisA = Convert.ToInt32(Console.ReadLine());
            int plotisA = Convert.ToInt32(Console.ReadLine());
            int aukstisA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite B dezutes matmenis ilgi, ploti, auksti: ");
            int ilgisB = Convert.ToInt32(Console.ReadLine());
            int plotisB = Convert.ToInt32(Console.ReadLine());
            int aukstisB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("A dezutes matmenys yra {0} {1} {2}" , ilgisA, plotisA, aukstisA);
            Console.WriteLine("B dezutes matmenys yra {0} {1} {2}", ilgisB, plotisB, aukstisB);
            

            // pirmine salyga ar telpa visi kintamieji i intervala
            if ((ilgisA >= 1 && ilgisA <= 100) && (plotisA >= 1 && plotisA <= 100) && (aukstisA >= 1 && aukstisA <= 100) &&
                (ilgisB >= 1 && ilgisB <= 100) && (plotisB >= 1 && plotisB <= 100) && (aukstisB >= 1 && aukstisB <= 100))
            {
                // pradedam tikrint ar B telpa A
                // Nevartom, tikrinam normalu atitikima ilgio su ilgiu, plocio su plociu, aukscio su auksciu
                if ((ilgisA - ilgisB >= 1) && (plotisA - plotisB >= 1) && (aukstisA - aukstisB >= 1))
                {
                    Console.WriteLine("B dezute telpa A dezuteje");
                }
                // vartom B ir sukeiciam ilgi su plociu
                else if ((ilgisA - plotisB >= 1) && (plotisA - ilgisB >= 1) && (aukstisA - aukstisB >= 1))
                {
                    Console.WriteLine("B dezute telpa A dezuteje");
                }
                // vartom B ir sukeiciam ilgi su auksciu
                else if ((ilgisA - aukstisB >= 1) && (plotisA - plotisB  >= 1) && (aukstisA - ilgisB >= 1))
                {
                    Console.WriteLine("B dezute telpa A dezuteje");
                }
                // vartom B ir sukeiciam ploti su auksciu
                else if ((ilgisA - ilgisB >= 1) && (plotisA - aukstisB >= 1) && (aukstisA - plotisB >= 1))
                {
                    Console.WriteLine("B dezute telpa A dezuteje");
                }
                // Tikrinam ar A telpa B
                // Nevartom, tikrinam normalu atitikima ilgio su ilgiu, plocio su plociu, aukscio su auksciu
                else if ((ilgisB - ilgisA >= 1) && (plotisB - plotisA >= 1) && (aukstisB - aukstisA >= 1))
                {
                    Console.WriteLine("A dezute telpa B dezuteje");
                }
                // vartom A ir sukeiciam ilgi su plociu
                else if ((ilgisB - plotisA >= 1) && (plotisB - ilgisA >= 1) && (aukstisB - aukstisA >= 1))
                {
                    Console.WriteLine("A dezute telpa B dezuteje");
                }
                // vartom A ir sukeiciam ilgi su auksciu
                else if ((ilgisB - aukstisA >= 1) && (plotisB - plotisA >= 1) && (aukstisB - ilgisA >= 1))
                {
                    Console.WriteLine("A dezute telpa B dezuteje");
                }
                // vartom A ir sukeiciam ploti su auksciu
                else if ((ilgisB - ilgisA >= 1) && (plotisB - aukstisA >= 1) && (aukstisB - plotisA >= 1))
                {
                    Console.WriteLine("A dezute telpa B dezuteje");
                }
                else
                {
                    Console.WriteLine("Dezutes netelpa viena kitoje");
                }

            }
            else
                Console.WriteLine("KLAIDA: Kintamieji uz ribu, turi buti nuo 1 iki 100 imtinai");

            Console.ReadKey();
        }
    }
}
