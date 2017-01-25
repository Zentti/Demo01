using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taulukko1 = { 10, 20, 30, 40, 50 };
            int[] taulukko2 = { 5, 15, 25, 35, 45 };
            int[] yhdtaul = new int[10];
            int j = 5;
            int temp;

            for (int i = 0; i<5;i++,j++)
            {
                yhdtaul[i] = taulukko1[i];
                yhdtaul[j] = taulukko2[i];
            }
           
            for (int i = 0; i <= 9; i++)
            {
                for (int k = 0; k < 9; k++)
                {
                    if (yhdtaul[k] > yhdtaul[k + 1])
                    {
                        temp = yhdtaul[k];
                        yhdtaul[k] = yhdtaul[k + 1];
                        yhdtaul[k + 1] = temp;
                    }
                }
            }
            foreach (int luku in yhdtaul)
            {
                Console.Write(luku + ", ");
            }
        }
    }
}
