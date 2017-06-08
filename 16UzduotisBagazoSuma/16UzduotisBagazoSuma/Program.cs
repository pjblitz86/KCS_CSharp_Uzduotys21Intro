using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16UzduotisBagazoSuma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KIEK SVERIA DRAUGU BAGAZAS?");
            Console.WriteLine();
            bool arIvesti = true;
            double kupriniuSvoris = 0;
            int kuprinesIrDraugoNumeris = 0;

            Console.WriteLine("Iveskite bagazo kaina uz 1 kg:");
            double bagazoKainaUzKg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite kupriniu realius svorius vienas po kito, kg:");
            Console.WriteLine("Kai ivesite paskutines kuprines svori parasykite -1"); 

            while (arIvesti)
            {
                double ivedamasSvoris = Convert.ToDouble(Console.ReadLine());
                if (ivedamasSvoris >=0)
                {
                    kupriniuSvoris += ivedamasSvoris;
                    kuprinesIrDraugoNumeris++;
                }
                else
                {
                    arIvesti = false;
                }
            }
            
            double kainaUzVisaBagaza = bagazoKainaUzKg * kupriniuSvoris;
            double kainaUzBagaza1Draugui = (double) (kainaUzVisaBagaza / kuprinesIrDraugoNumeris);

            Console.WriteLine("Viso stovyklavo {0} draugu. Visas bagazo svoris: {1:0.00} kg.", kuprinesIrDraugoNumeris, kupriniuSvoris);
            Console.WriteLine("Kaina uz visa bagaza gavosi: {0:0.00} Eur.", kainaUzVisaBagaza);
            Console.WriteLine("Jei draugai mesis kartu, kiekvienas tures sumoketi po {0:0.00} Eur.", kainaUzBagaza1Draugui); 
                               
            Console.ReadKey();

        }
    }
}
