using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6UzduotisMiegoFormule
{
    class Program
    {

        // Miego formule t = 8 + (18 - a)/2, t-laikas val, a-amzius metais.
        // Apskaiciuoti t, paprasant vartotojo ivesti a < 18.
        static void Main(string[] args)
        {
            Console.WriteLine("MIEGO FORMULE");
            Console.WriteLine("*************");
            Console.WriteLine();
            Console.Write("Iveskite amziu nuo 0 iki 18 imtinai: ");
            double amziusMetais = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine();

            if (amziusMetais >= 0 && amziusMetais <= 18)
            {
                int valandosPramiegotosPerPara = (int)((8 + (18 - amziusMetais)/2));
                long valandosPramiegotosPerIvestusMetus = (long)(valandosPramiegotosPerPara * 365 * amziusMetais);
                double metaiPramiegoti = (double)(valandosPramiegotosPerIvestusMetus / 24 / 365);
                Console.WriteLine("Ivedete {0} metu. Zmogus per tiek laiko turejo vidutiniskai miegoti\n{1} valandu per para\nviso pramiegojo {2} val per tiek metu\narba {3:0.00} metu pramiegojo."
                                 , amziusMetais, valandosPramiegotosPerPara, valandosPramiegotosPerIvestusMetus, metaiPramiegoti);
            }
            else
            {
                Console.WriteLine("KLAIDA: Amziu ivedete ne skaiciais arba ne nuo 0 iki 18 imtinai.");
            }
            Console.ReadKey();
        }
    }
}
