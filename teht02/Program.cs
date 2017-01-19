using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Anna pisteet > ");
            number = int.Parse(Console.ReadLine());

            switch(number)
            {
                case 0:
                case 1:
                    Console.WriteLine("Koulu numero on 0");
                    break;

                case 2:
                case 3:
                    Console.WriteLine("Koulu numero on 1");
                    break;

                case 4:
                case 5:
                    Console.WriteLine("Koulu numero on 2");
                    break;

                case 6:
                case 7:
                    Console.WriteLine("Koulu numero on 3");
                    break;

                case 8:
                case 9:
                    Console.WriteLine("Koulu numero on 4");
                    break;

                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Koulu numero on 5");
                    break;

                default:
                    Console.WriteLine("Ei oikea pisteraja");
                    break;
            }
            Console.ReadLine();
        }
    }
}
