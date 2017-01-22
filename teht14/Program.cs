using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht14
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            int[] arvosanat = { 0, 0, 0, 0, 0, 0 };
            
            do
            {
                Console.Write("Anna arvosana: ");
                luku = int.Parse(Console.ReadLine());

                if (luku == 0) arvosanat[0]++;
                else if (luku == 1) arvosanat[1]++;
                else if (luku == 2) arvosanat[2]++;
                else if (luku == 3) arvosanat[3]++;
                else if (luku == 4) arvosanat[4]++;
                else if (luku == 5) arvosanat[5]++;

            } while (luku != 6);

            for (int i = 0; i < arvosanat.Length; i++)
            {
                Console.WriteLine(i + ": " + String.Concat(Enumerable.Repeat("*", arvosanat[i])));
            }
        }
    }
}
