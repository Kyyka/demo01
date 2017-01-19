using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalseconds;
            Console.Write("Give seconds: ");
            totalseconds = int.Parse(Console.ReadLine());

            int hours = totalseconds / 3600;
            int minutes = (totalseconds % 3600) / 60;
            int seconds = totalseconds % 60;

            Console.WriteLine("Givens seconds can be shown also as: " + hours + " tunti(a) " + minutes + " minuutit " + seconds + " sekuntit");
        }
    }
}
