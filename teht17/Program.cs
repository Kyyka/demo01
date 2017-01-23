using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taulukko1 = { 10, 20, 30, 40, 50 };
            int[] taulukko2 = { 5, 15, 25, 35, 45 };
            //taulukko 1 ja 2 yhdistyvät. Numerot järjestetään.
            int[] taulukko3 = taulukko1.Concat(taulukko2).OrderBy(x => x).ToArray();

            //string.join tekee taulukon string ja laitetaan ", " väliin.
            Console.WriteLine("Luvut taulukossa 1 : " + String.Join(", ", taulukko1));
            Console.WriteLine("Luvut taulukossa 2 : " + String.Join(", ", taulukko2));
            Console.WriteLine("Luvut yhdistetyssä taulukossa : " + String.Join(", ", taulukko3));
        }
    }
}
