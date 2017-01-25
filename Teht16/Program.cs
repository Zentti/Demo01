using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random s = new Random();
            int random = s.Next(0,100);
            int arvattuluku;
            bool arvaus = false;
            int laskuri = 0;

            while (arvaus != true)
            {

                Console.WriteLine("Anna luku väliltä 0-100 ");
                arvattuluku = int.Parse(Console.ReadLine());
                laskuri++;

                if (arvattuluku > random)
                    Console.WriteLine("Luku on pienempi");
                else if (arvattuluku < random)
                    Console.WriteLine("Luku on suurempi");
                else if (arvattuluku == random)
                {
                    Console.WriteLine("Arvasit oikein " + laskuri + ". yrityksellä");
                    arvaus = true;
                }
            }
        }
    }
}
