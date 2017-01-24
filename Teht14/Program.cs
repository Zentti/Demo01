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
                laskuri++;

                switch (kirjotettu)
                {
                    case 0:
                        luku0++;
                        break;

                    case 1:
                        luku1++;
                        break;

                    case 2:
                        luku2++;
                        break;

                    case 3:
                        luku3++;
                        break;

                    case 4:
                        luku4++;
                        break;

                    case 5:
                        luku5++;
                        break;

                    default:
                        Console.WriteLine("Arvosana ei ollut asteikolta 0-5! ");
                        break;
                }
            }
            Console.WriteLine("Arvosanat:");
            Console.WriteLine("0: ");
            for (int i = 0;i<luku0;i++)
                Console.Write("*");

            Console.WriteLine();
            Console.WriteLine("1: ");
            for (int i = 0; i < luku1; i++)
                Console.Write("*");

            Console.WriteLine();
            Console.WriteLine("2: ");
            for (int i = 0; i < luku2; i++)
                Console.Write("*");

            Console.WriteLine();
            Console.WriteLine("3: ");
            for (int i = 0; i < luku3; i++)
                Console.Write("*");

            Console.WriteLine();
            Console.WriteLine("4: ");
            for (int i = 0; i < luku4; i++)
                Console.Write("*");

            Console.WriteLine();
            Console.WriteLine("5: ");
            for (int i = 0; i < luku5; i++)
                Console.Write("*");

            Console.WriteLine();
        }
    }
}
