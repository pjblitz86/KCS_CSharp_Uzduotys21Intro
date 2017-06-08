using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Kamuoliukai
{    // Yra 8 kamuoliukai vienas is ju yra defektuotas ir sveria maziau nei kiti. Jus turite svarstykles pamatuoti svori.
     // Atliekant 2 sverimus nustatyti defektuota kamuoliuka
    class Program
    {
        static void Main(string[] args)
        {
            int Sk1 = 2;
            int Sk2 = 2;
            int Sk3 = 2;
            int Sk4 = 2;
            int Sk5 = 1;
            int Sk6 = 2;
            int Sk7 = 2;
            int Sk8 = 2;

            int suma1 = Sk1 + Sk2 + Sk3;
            int suma2 = Sk4 + Sk5 + Sk6;

            if (suma1 == suma2)
            {
                if (Sk7 > Sk8)
                {
                    Console.WriteLine("8 kamuoliukas defektuotas");
                    
                } else
                {
                  Console.WriteLine("7 kamuoliukas defektuotas");
                }

            } else if (suma1 > suma2)
            {
              // kazkuris is sk4, sk5, sk6 yra blogas
              if (Sk4 == Sk5)
                {
                    Console.WriteLine("6 kamuoliukas defektuotas");
                } else if (Sk4 < Sk5)
                {
                    Console.WriteLine("4 kamuoliukas defektuotas");
                } else
                {
                    Console.WriteLine("5 kamuoliukas defektuotas");
                }

            } else 
            {
                // kazkuris is sk1, sk2, sk3 yra blogas
                if (Sk1 == Sk2)
                {
                    Console.WriteLine("3 kamuoliukas defektuotas");
                } else if (Sk1 < Sk2)
                {
                    Console.WriteLine("1 kamuoliukas defektuotas");
                } else 
                {
                    Console.WriteLine("2 kamuoliukas defektuotas");
                }
            }
            Console.ReadKey();
        }
    }
}
