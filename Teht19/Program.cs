using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht19
{
    class Program
    {
        static void Main(string[] args)
        {
            string arvattava = "aadolf";
            string arvaus;
            int maara = 15;
            List<string> arvatut = new List<string>();

            Console.WriteLine("Hirsipuu peli");

            while (maara != 0)
            {
                Console.WriteLine("Anna kirjain");
                arvaus = Console.ReadLine();
                

                if (arvaus.Length > 1)
                {
                    Console.WriteLine("Ei sopiva");
                }
                else
                {

                    if (arvattava.Contains(arvaus) == true)
                    {
                        Console.WriteLine("Kirjain on sanassa, arvauksia jäljellä " + maara);
                        arvatut.Add(arvaus);


                    }
                    else
                    {
                        Console.WriteLine("Kirjain ei ole sanassa, arvauksia jäljellä " + maara);
                        arvatut.Add(arvaus);

                    }
                    maara--;
                }

                Console.Write("\r\nJo käytetyt kirjaimet ");
                foreach (string k in arvatut)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();

            }
            Console.WriteLine("Oikea sana oli " + arvattava);
        }
    }
}
