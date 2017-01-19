using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            double matka;
            double kulutus = 7.02;
            double bensa = 1.595;

            Console.Write("Anna matka: ");
            matka = double.Parse(Console.ReadLine());

            double kerroin = matka / 100;
            Console.WriteLine("Bensaa kuluu " + kerroin * kulutus + "litraa, kustannus " + kerroin * kulutus * bensa + " euroa ");

        }
    }
}
