using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht15
{
    class Program
    {
        static void Main(string[] args)
        {
            int kerrosluku;
            int vali;
            int tahti;

            Console.WriteLine("Anna luku ");
            kerrosluku = int.Parse(Console.ReadLine());

            for (int i = 1; i <= (kerrosluku - 2); i++)
            {
                for (vali = 1; vali <= (kerrosluku - i); vali++)
                    Console.Write(" ");
                for (tahti = 1; tahti <= i; tahti++)
                    Console.Write('*');
                for (tahti = (i - 1); tahti >= 1; tahti--)
                    Console.Write('*');
                Console.WriteLine();  
            }

            for (int i = 1; i <= (kerrosluku - 1); i++)
            {
                Console.Write(" ");
            }
            Console.Write('*');

            Console.WriteLine();

            for (int i = 1; i <= (kerrosluku - 1); i++)
            {
                Console.Write(" ");
            }
            Console.Write('*');

            Console.WriteLine();

        }
    }
}
