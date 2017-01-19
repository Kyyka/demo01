using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht08
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

            /*Sijoitetaan allnumbers taulukkoon number, number2 ja number3. Tulostetaan suuri taulukon numero
            käyttämällä Max() methodia. */
            int[] allnumbers =new int[]{number, number2, number3};
            int maxnumber = allnumbers.Max();
            /* Tai haetaan suoraan maksiminumero käyttäen Math.Max-metodia
            Console.WriteLine(Math.Max(Math.Max(number, number2), number3)); */
            Console.WriteLine("Suurin luku on: " + maxnumber);
        }
    }
}
