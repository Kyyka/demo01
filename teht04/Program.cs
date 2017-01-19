using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.Write("Give your age pls: ");
            age = int.Parse(Console.ReadLine());

            if (age < 18) Console.WriteLine("You are underage!");
            else if (age >= 18 && age <= 65) Console.WriteLine("You are an adult!");
            else if (age >= 65) Console.WriteLine("You are senior!");
        }
    }
}
