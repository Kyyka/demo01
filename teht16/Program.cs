using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 100);
            int userGuess = 0;
            int trys = 1;

            while (userGuess != number)
            {
                Console.Write("Arvaa luku: ");
                int.TryParse(Console.ReadLine(), out userGuess);
                if (userGuess != 0)
                { 
                    trys++;
                    if (userGuess == number)
                    {
                        Console.WriteLine("Hienoa, arvasit luvun {0} kerralla", trys);
                    }
                    else
                    {
                        if (userGuess > number)
                        {
                            Console.WriteLine("Luku on pienempi", userGuess);
                        }
                        else if (userGuess < number)
                        {
                            Console.WriteLine("Luku on suurempi", userGuess);
                        }
                    }
                }

            }
        }
    }
}
