using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int number2;
            int number3;
            Console.Write("Give first number: ");
            number = int.Parse(Console.ReadLine());
            Console.Write("Give second number: ");
            number2 = int.Parse(Console.ReadLine());
            Console.Write("Give third number: ");
            number3 = int.Parse(Console.ReadLine());

            int sum = number + number2 + number3;
            int average = sum / 3;

            Console.WriteLine("Sum is: " + sum);
            Console.WriteLine("Average is: " + average);
        }
    }
}
