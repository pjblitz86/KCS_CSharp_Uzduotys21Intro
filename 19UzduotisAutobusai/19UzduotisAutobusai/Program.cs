using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19UzduotisAutobusai
{
    class Program
    {
        // mieste vazineja n autobusu. Kiekvienas ju perveza per diena keleiviu skaiciu k1, k2..
        // Paskaiciuoti  kiek is viso keleiviu perveza visi autobusai ir kiek autobusu a perveza daugiau nei 180.
        static void Main(string[] args)
        {
            Console.WriteLine("Keleiviu pervezimas autobusu per diena");
            Console.WriteLine();
            bool arIvedimas = true;
            int autobusuSkaicius = 0;
            int keleiviuSkaicius = 0;
            int keliAutobusai180 = 0;

            Console.WriteLine("Iveskite keleiviu skaiciu kiekviename autobuse.");
            Console.WriteLine("Jei norite baigti ivedima parasykite -1");

            while (arIvedimas)
            {
                int ivedamiKeleiviai = Convert.ToInt32(Console.ReadLine());
                if (ivedamiKeleiviai >= 0)
                {
                autobusuSkaicius++;
                keleiviuSkaicius += ivedamiKeleiviai;
                    if(ivedamiKeleiviai > 180)
                    {
                        keliAutobusai180++;
                    }
                }
                else
                {
                    arIvedimas = false;
                }
               
            }
            Console.WriteLine("Viso autobusu: {0}. Jie perveza {1} keleiviu per diena.", 
                autobusuSkaicius, keleiviuSkaicius);

            Console.WriteLine("{0} autobusai perveza daugiau nei 180 keleiviu per diena kiekvienas atskirai", 
                                keliAutobusai180);

            Console.ReadKey();
        }
    }
}
