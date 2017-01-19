using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            double hinta = 1.595;
            int matka;

            Console.Write("Anna matka ");
            matka = int.Parse(Console.ReadLine());

            double kulutus;
            double kustannus;

            kulutus = 7.02 / 100 * matka;
            kustannus = kulutus * hinta;

            Console.WriteLine("Bensaa kuluu " + kulutus + " litraa, kustannus " + kustannus + " euroa");
        }
    }
}
