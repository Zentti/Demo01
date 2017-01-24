using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht14
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku0 = 0;
            int luku1 = 0;
            int luku2 = 0;
            int luku3 = 0;
            int luku4 = 0;
            int luku5 = 0;
            int kirjotettu;
            int laskuri = 0;

            while (laskuri < 8)
            {
                Console.Write("Anna arvosana asteikolla 0-5 ");
                kirjotettu = int.Parse(Console.ReadLine());
                

                switch (kirjotettu)
                {
                    case 0:
                        luku0++;
                        laskuri++;
                        break;

                    case 1:
                        luku1++;
                        laskuri++;
                        break;

                    case 2:
                        luku2++;
                        laskuri++;
                        break;

                    case 3:
                        luku3++;
                        laskuri++;
                        break;

                    case 4:
                        luku4++;
                        laskuri++;
                        break;

                    case 5:
                        luku5++;
                        laskuri++;
                        break;

                    default:
                        Console.WriteLine("Arvosana ei ollut asteikolta 0-5! ");
                        break;
                }
            }
            Console.WriteLine("Arvosanat:");
            string nollaa = new string('*', luku0);
            Console.WriteLine("0: " + nollaa);

            string ykkosta = new string('*', luku1);
            Console.WriteLine("1: " + ykkosta);

            string kakkosta = new string('*', luku2);
            Console.WriteLine("2: " + kakkosta);

            string kolmosta = new string('*', luku3);
            Console.WriteLine("3: " + kolmosta);

            string nelosta = new string('*', luku4);
            Console.WriteLine("4: " + nelosta);

            string vitosta = new string('*', luku5);
            Console.WriteLine("5: " + vitosta);

            Console.WriteLine();
        }
    }
}
