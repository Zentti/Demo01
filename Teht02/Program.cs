using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            int pisteet;
            Console.Write("Syötä pistemääräsi: ");
            pisteet = int.Parse(Console.ReadLine());

            if (pisteet <= 1) Console.WriteLine("Numerosi on 0");

            else if (pisteet >= 2 && pisteet <= 3) Console.WriteLine("Numerosi on 1");

            else if (pisteet >= 4 && pisteet <= 5) Console.WriteLine("Numerosi on 2");

            else if (pisteet >= 6 && pisteet <= 7) Console.WriteLine("Numerosi on 3");

            else if (pisteet >= 8 && pisteet <= 9) Console.WriteLine("Numerosi on 4");

            else if (pisteet >= 10 && pisteet <= 12) Console.WriteLine("Numerosi on 5");
        }
    }
}
