using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taulukko = new int[5];
            int temp;
            int summa = 0;
            Console.WriteLine("Anna pisteet ");
            taulukko[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna pisteet ");
            taulukko[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna pisteet ");
            taulukko[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna pisteet ");
            taulukko[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna pisteet ");
            taulukko[4] = int.Parse(Console.ReadLine());

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    if (taulukko[j] > taulukko[j + 1])
                    {
                        temp = taulukko[j];
                        taulukko[j] = taulukko[j + 1];
                        taulukko[j + 1] = temp;
                    }
                } 
            }
            summa = (taulukko[1] + taulukko[2] + taulukko[3]);
            Console.WriteLine("Kokonaispisteet ovat " + summa); 
        }
    }
}
