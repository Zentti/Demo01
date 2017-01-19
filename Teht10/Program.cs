using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taulukko = new int[9];

            taulukko[0] = 1;
            taulukko[1] = 2;
            taulukko[2] = 33;
            taulukko[3] = 44;
            taulukko[4] = 55;
            taulukko[5] = 68;
            taulukko[6] = 77;
            taulukko[7] = 96;
            taulukko[8] = 100;

            for (int i = 0; i < taulukko.Length; i++)
            {
                if (taulukko[i] % 2 == 0)
                    Console.WriteLine("HEP");
            }
        }
    }
}
