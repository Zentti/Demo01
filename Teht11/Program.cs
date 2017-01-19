using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht11
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            Console.Write("Anna luku ");
            luku = int.Parse(Console.ReadLine());
            

            for (int rivi = 1; rivi <= luku; rivi++)
            {
                for (int sivu = 1; sivu <= rivi; sivu++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            

        }
    }
}
