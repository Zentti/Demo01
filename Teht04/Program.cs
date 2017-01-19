using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            int ikä;

            Console.Write("Anna ikäsi ");
            ikä = int.Parse(Console.ReadLine());

            if (ikä < 18) Console.WriteLine("alaikäinen");
            else if (ikä >= 10 && ikä <= 65) Console.WriteLine("aikuinen");
            else if (ikä > 65) Console.WriteLine("seniori");
        }
    }
}
