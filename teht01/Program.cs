using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask number
            int number;
            Console.Write("Give a number > ");
            number = int.Parse(Console.ReadLine()); // "10" -> 10
            // Show number text
            switch(number)
            {
                case 1: Console.WriteLine("Yksi"); break;
                case 2: Console.WriteLine("Kaksi"); break;
                case 3: Console.WriteLine("Kolme"); break;
                default: Console.WriteLine("Joku muu luku"); break;
            }
            // Stops without debugging
            Console.ReadLine();
        }
    }
}
