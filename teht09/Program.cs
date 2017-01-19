using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht09
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            do
            {
                Console.Write("Anna luku: ");
                luku = int.Parse(Console.ReadLine());
            } while (luku != 0);

        }
    }
}
