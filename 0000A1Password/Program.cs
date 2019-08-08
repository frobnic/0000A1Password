using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0000A1Password
{
    class Program
    {
        static void Main(string[] args)
        {
            char c1, c2, c3, c4;
            int i = 0;

            c1 = Console.ReadKey().KeyChar;
            c2 = Console.ReadKey().KeyChar;
            c3 = Console.ReadKey().KeyChar;
            c4 = Console.ReadKey().KeyChar;

            c1 = char.ToUpper(c1);
            c2 = char.ToUpper(c2);
            c3 = char.ToUpper(c3);
            c4 = char.ToUpper(c4);

            if (c1 == 'P' || c1 == 'R' || c1 == 'O' || c1 == 'G')
                i++;

            if (c2 == 'P' || c2 == 'R' || c2 == 'O' || c2 == 'G')
                i++;

            if (c3 == 'P' || c3 == 'R' || c3 == 'O' || c3 == 'G')
                i++;

            if (c4 == 'P' || c4 == 'R' || c4 == 'O' || c4 == 'G')
                i++;

            if (i == 4)
                Console.WriteLine("Yippie, Crazy Hax0r!");
            else
                Console.WriteLine("Lam0r");

        }
    }
}
