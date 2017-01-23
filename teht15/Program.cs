using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht15
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, k;
            Console.Write("Anna luku: ");
            num = int.Parse(Console.ReadLine());
            for (i = 1; i <= num - 2; i++)
            {
                string padding = String.Concat(Enumerable.Repeat(" ", num - 2 - i));
                string star = String.Concat(Enumerable.Repeat("*", i + (i - 1)));
                Console.WriteLine(padding + star);
            }

            for (k = 0; k < 2; k++)
            {
                string padding = String.Concat(Enumerable.Repeat(" ", num - 3));
                Console.WriteLine(padding + "*");
            }
                

            
        }
    }
}
