using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int number3;
            int summa;
            int ka;
            Console.Write("Anna ensimmäinen kolmesta numerosta: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen kolmesta numerosta: ");
            number2 = int.Parse(Console.ReadLine());
            Console.Write("Anna kolmas kolmesta numerosta: ");
            number3 = int.Parse(Console.ReadLine());

            summa = (number1 + number2 + number3);
            ka = (summa / 3);

            Console.WriteLine("Summa on " + summa);
            Console.WriteLine("Keskiarvo on " + ka);


        }
    }
}
