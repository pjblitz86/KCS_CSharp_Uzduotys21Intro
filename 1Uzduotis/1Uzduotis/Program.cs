using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PITAGORO TEOREMA. Nezinomos krastines apskaiciavimas");
            Console.WriteLine("****************************************************");
            Console.WriteLine();
            Console.Write("Iveskite staciojo trikampio istrizaines ilgi: ");
            double istrizainesIlgis = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite vienos krastines (galimi realus skaiciai) ilgi: ");
            double pirmosKrastinesIlgis = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("**********************************");
            Console.WriteLine("ATSAKYMAS");

            // pitagoro teorema
            // c2 = a2 + b2;
            // viena krastine bus b2 = c2 - a2
            if ((istrizainesIlgis > 0) && (pirmosKrastinesIlgis > 0))
            {
                double antrosKrastinesIlgis = Math.Sqrt((istrizainesIlgis * istrizainesIlgis) -
                (pirmosKrastinesIlgis * pirmosKrastinesIlgis));
                Console.WriteLine("Ivedete istrizaines ilgi {0} ir vienos krastines ilgi {1}"
                    , istrizainesIlgis, pirmosKrastinesIlgis);
                Console.WriteLine("Antros krastines ilgis pagal Pitagoro teorema yra: {0}", antrosKrastinesIlgis);
            }
            else
            {
                Console.WriteLine("KLAIDA: Ivesta istrizaine ir/ar krastine yra ne skaiciai arba <=0");
            }

            Console.ReadKey();
        }
    }
}
