using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taulukko = new int[5];


            Console.Write("Anna luku ");
            taulukko[0] = int.Parse(Console.ReadLine());
            Console.Write("Anna luku ");
            taulukko[1] = int.Parse(Console.ReadLine());
            Console.Write("Anna luku ");
            taulukko[2] = int.Parse(Console.ReadLine());
            Console.Write("Anna luku ");
            taulukko[3] = int.Parse(Console.ReadLine());
            Console.Write("Anna luku ");
            taulukko[4] = int.Parse(Console.ReadLine());


            Console.WriteLine(taulukko[4] + " " + taulukko[3] + " " + taulukko[2] + " " + taulukko[1] + " " + taulukko[0]);


        }
    }
}
