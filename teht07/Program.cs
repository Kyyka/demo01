using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht07
{
    class Program
    {
        static void Main(string[] args)
        {
            int vuosi;
            Console.Write("Anna vuosi: ");
            vuosi = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(vuosi))
            {
                Console.WriteLine("Vuosi on karkausvuosi");
            } else
            {
                Console.WriteLine("Vuosi ei ole karkausuvosi");
            }
        }
    }
}
