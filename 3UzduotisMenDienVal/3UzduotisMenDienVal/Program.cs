using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3UzduotisMenDienVal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metai paversti menesiais, dienomis ir valandomis. 1 metai = 365 dienos");
            Console.WriteLine("**********************************************************************");
            Console.Write("Iveskite metu skaiciu: ");
            double metai = Convert.ToDouble(Console.ReadLine());

            if (metai >= 0)
            {
                double menesiai = metai * 12;
                Console.WriteLine();
                Console.WriteLine("Ivesta {0:0.0} metai(-u).\nTai sudarys:\n{1:0.0} menesiu(-i).", metai, menesiai);
                long dienos = (long)(metai * 365);
                Console.WriteLine("{0} dienu(-os).", dienos);
                long valandos = (long)(metai * 365 * 24);
                Console.WriteLine("{0} valandu(-as).", valandos);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("KLAIDA: Metus ivedete ne skaiciais arba metai <= 0");
            }

            Console.ReadKey();
        }
    }
}
