using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht18
{
    class Program
    {
        static void Main(string[] args)
        {
            string sana;
            bool testi = true;

            Console.Write("Anna sana ");
            sana = Console.ReadLine();

            for (int i = 0; i < sana.Length/2; i++)
            {
                if(sana[i] != sana[sana.Length -1 - i])
                {
                    Console.WriteLine("Sana ei ole palindromi!");
                    testi = false;
                    break;
                } 
    
            }
            if (testi == true)
            {
                Console.WriteLine("Sana on palindromi!");
            }
        }
    }
}
