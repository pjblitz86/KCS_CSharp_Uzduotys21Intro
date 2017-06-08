using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21UzduotisJaponukalendorius
{
    class Program
    {
        private void kurisCiklas(int m)
        {
            if (m >= 1807 && m<=2200)
            {
                // iskviesti metoda kuris tikrina metu spalvas
            }
            else if (m>=1800 && m<=1806)
            {
                switch (m)
                {
                    case 1806:
                        Console.WriteLine("Juodos spalvos metai (baigiasi 0)");
                        break;
                    case 1805:
                        Console.WriteLine("Juodos spalvos metai (baigiasi 9)");
                        break;
                    case 1804:
                        Console.WriteLine("Baltos spalvos metai");
                        break;
                    case 1803:
                        Console.WriteLine("Baltos spalvos metai");
                        break;
                    case 1802:
                        Console.WriteLine("Geltonos spalvos metai");
                        break;
                    case 1801:
                        Console.WriteLine("Geltonos spalvos metai");
                        break;
                    case 1800:
                        Console.WriteLine("Raudonos spalvos metai");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Metai ivesti ne nurodytame intervale arba blogai ivesta");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Japonu kalendorius");
            Console.WriteLine();

            Console.WriteLine("Iveskite metus nuo 1800 iki 2200 imtinai");
            int metai = Convert.ToInt32(Console.ReadLine());

            Program japonuMetai = new Program();
            japonuMetai.kurisCiklas(metai);


        }
    }
}
