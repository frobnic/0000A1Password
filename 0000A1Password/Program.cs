using System;

namespace _0000A1Password
{
    class Program
    {
        static void Main(string[] args)
        {
            char c1, c2, c3, c4;
            int i = 0;
            Boolean done = false;

            for (int n = 1; n < 4; n++)
            {
                c1 = Console.ReadKey().KeyChar;
                c2 = Console.ReadKey().KeyChar;
                c3 = Console.ReadKey().KeyChar;
                c4 = Console.ReadKey().KeyChar;

                c1 = char.ToUpper(c1);
                c2 = char.ToUpper(c2);
                c3 = char.ToUpper(c3);
                c4 = char.ToUpper(c4);

                if (c1 == 'P' || c2 == 'P' || c3 == 'P' || c4 == 'P')
                    i++;

                if (c1 == 'R' || c2 == 'R' || c3 == 'R' || c4 == 'R')
                    i++;

                if (c1 == 'O' || c2 == 'O' || c3 == 'O' || c4 == 'O')
                    i++;

                if (c1 == 'G' || c2 == 'G' || c3 == 'G' || c4 == 'G')
                    i++;

                if (i == 4)
                {
                    Console.WriteLine("Yippie, Crazy Hax0r!");
                    done = true;
                    break;
                }
                else
                    Console.WriteLine("Lam0r");
            }
            if (!done)
                Console.WriteLine("You're so fail!");
        }
    }
}
