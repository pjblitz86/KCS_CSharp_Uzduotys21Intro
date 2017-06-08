using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20UzduotisArmstrongoSkaicius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ARMSTRONGO SKAICIUS");
            Console.WriteLine("Jei 3 skaitmenu pakeltu 3iuoju laipsniu suma lygi paciam skaiciui");
            Console.WriteLine();

            Console.WriteLine("Iveskite sveika trizenkli skaiciu ir patikrinsiu ar jis yra Armstrongo skaicius");
            int ivestasSkaicius = Convert.ToInt32(Console.ReadLine());

            // issireiskiam kiekviena skaitmeni
            int Skaitmuo1 = ivestasSkaicius / 100;
            int Skaitmuo2 = (ivestasSkaicius % 100) / 10;
            int Skaitmuo3 = ivestasSkaicius % 10;
           
            if (ivestasSkaicius == Math.Pow (Skaitmuo1, 3) + Math.Pow(Skaitmuo2, 3) + Math.Pow(Skaitmuo3, 3))
            {
                Console.WriteLine("{0} yra Armstrongo skaicius", ivestasSkaicius);
            }
            else
            {
                Console.WriteLine("Tai nera Armstrongo skaicius");
            }
            Console.ReadKey();
        }
    }
}
