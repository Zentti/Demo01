using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht09
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku = 1;
            int summa = 0;

            while (luku != 0) 
            {
                Console.Write("Anna luku ");
                luku = int.Parse(Console.ReadLine());
                summa = summa + luku;
                
                
            }
            Console.WriteLine("Lukujen summa on " + summa);

        }
    }
}
