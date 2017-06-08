using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18UzduotisKatinas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek bus dresuojamas katinas?");
            Console.WriteLine();
            Console.WriteLine("Iveskite kiek minuciu buvo dresuojamas katinas kiekviena diena");
            Console.WriteLine("Kai ivesite paskutini irasa, spauskite 0");
            bool arIvesta = true;
            int dienuSkaicius = 0;
            int minuciuSuma = 0;

            while(arIvesta)
            {
                int minutesDresavimo = Convert.ToInt32(Console.ReadLine());
                minuciuSuma += minutesDresavimo;
                dienuSkaicius++;
                if (minutesDresavimo == 0)
                {
                    arIvesta = false;
                }
            }
            Console.WriteLine("Andrius dresavo katina {0} dienas, is viso {1} minuciu"
                                , dienuSkaicius, minuciuSuma);
            if (dienuSkaicius != 0)
            {
                double vidutiniskaiMinPerDiena = (double)(minuciuSuma / dienuSkaicius);
                Console.WriteLine("Vidutiniskai per diena {0} minuciu", vidutiniskaiMinPerDiena);
            }
            Console.ReadKey();
        }
    }
}
