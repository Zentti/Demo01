using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            int aika;

            Console.Write("Syötä sekunttimäärä: ");
            aika = int.Parse(Console.ReadLine());

            int sekuntti;
            int minuutti = aika % 3600;
            int tunti;

            tunti = aika / 3600;
            minuutti = minuutti / 60;
            sekuntti = aika % 60;


            Console.WriteLine("Antamasi sekunttiaika voidaan ilmaista muodossa: " + tunti + " tunti " + minuutti + " minuuttia " + sekuntti + " sekuntia ");
        }
    }
}
