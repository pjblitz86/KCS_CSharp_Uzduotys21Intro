using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17UzduotisKlasesUgiaiFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vidutinio ugio klaseje apskaiciavimas pagal mokiniu skaiciu");
            Console.WriteLine();
            bool arGalimaIvesti = true;
            int mokiniuSkaicius = 0;
            int ugiuSumaCm = 0;

            Console.WriteLine("Iveskite mokiniu ugius cm. Kai ivesite paskutini, spauskite 0" );

            while (arGalimaIvesti)
            {
                int ivedamasUgisCm = Convert.ToInt32(Console.ReadLine());
                if (ivedamasUgisCm > 0)
                {
                mokiniuSkaicius++;
                ugiuSumaCm += ivedamasUgisCm;
                }
                else
                {
                arGalimaIvesti = false;
                }
            }

            double ugiuVidurkisCm = (double)(ugiuSumaCm / mokiniuSkaicius);

            Console.WriteLine("Ivestu mokiniu ugiu vidurkis yra: {0:0.0} cm", ugiuVidurkisCm);
            Console.ReadKey();
        }
    }
}
