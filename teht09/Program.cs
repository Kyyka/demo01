using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht09
{
    class Program
    {
        static void Main(string[] args)
               {
                   int luku;
                    int summa = 0;
                   do
                   {
                       Console.Write("Anna luku: ");
                       luku = int.Parse(Console.ReadLine());
                        summa = summa + luku;
                   } while (luku != 0);

                   Console.WriteLine("Annettujen lukujen summa on " + summa);
               }
           }
       }
