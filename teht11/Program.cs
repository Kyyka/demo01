using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht11
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            int i, j, k;
            Console.Write("Anna luku: ");
            luku = int.Parse(Console.ReadLine());
            for (i = 1; i <= luku; i++)
            {
                for (j = 1; j <= luku - i; j++)
                {
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
