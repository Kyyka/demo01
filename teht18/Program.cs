using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kysytään käyttäjältä lausetta/sanaa. Tallennetan se muuttujaan lause.
            Console.Write("Syötä lause/sana: ");
            string lause = Console.ReadLine();

            //Käännettään lause väärinpäin ja tallennettaan se muuttujaan takaperin_lause.
            char[] temp = lause.ToCharArray();
            Array.Reverse(temp);
            string takaperin_lause = new string(temp);

            //Jos alkuperäinen lause on sama kuin takaperin oleva lause se on palindrome, muuten ei.
            //ToLower() pienentää mahdolliset syötetyt isot kirjaimet pieniksi
            if (lause.ToLower().Equals(takaperin_lause.ToLower()))
            {
                Console.WriteLine("Palindrome!");
            }
            else
            {
                Console.WriteLine("Ei ole palindrome");
            }
        }
    }
}
