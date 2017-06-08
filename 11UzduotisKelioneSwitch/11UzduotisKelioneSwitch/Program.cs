using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11UzduotisKelioneSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KELIONES PASIRINKIMAS ... priklausomai nuo turimu pinigu");
            Console.WriteLine();
            Console.Write("Iveskite kiek Lt galite skirti kelionei: ");

            int pinigaiKelionei = Convert.ToInt32(Console.ReadLine());

            if (pinigaiKelionei >= 4000)
            {
                Console.WriteLine("Jums tiktu 1 grupes kelione");
            }
            else if (pinigaiKelionei >= 3000 && pinigaiKelionei <= 3999)
            {
                Console.WriteLine("Jums tiktu 2 grupes kelione");
            }
            else if (pinigaiKelionei >= 1000 && pinigaiKelionei <= 2999)
            {
                Console.WriteLine("Jums tiktu 3 grupes kelione");
            }
            else if (pinigaiKelionei < 1000)
            {
                Console.WriteLine("Jums tiktu 4 grupes kelione");
            }
            else
            {
                Console.WriteLine("Kazka blogai ivedete");
            }
            Console.ReadKey();
        }
    }
}
