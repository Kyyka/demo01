using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht13
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

            int sum = table[0] + table[1] + table[2] + table[3] + table[4] - table.Max() - table.Min();

            Console.WriteLine(sum);

        }
    }
}
