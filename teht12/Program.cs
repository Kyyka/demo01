using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] table = new int[5];

            Console.Write("Anna luku: ");
            table[0] = int.Parse(Console.ReadLine());
            Console.Write("Anna luku: ");
            table[1] = int.Parse(Console.ReadLine());
            Console.Write("Anna luku: ");
            table[2] = int.Parse(Console.ReadLine());
            Console.Write("Anna luku: ");
            table[3] = int.Parse(Console.ReadLine());
            Console.Write("Anna luku: ");
            table[4] = int.Parse(Console.ReadLine());

            Array.Reverse(table);

            for (int i = 0; i < table.Length; i++)
            {
                Console.WriteLine(table[i]);
            }

        }
    }
}
