using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Loopassignment.Pattern
{
    internal class Pattern7
    {
        public static void Main(String[] args)
        {
            int rows = 5;
            for (int i = rows; i >= 1; --i)
            {
                for (int space = 1; space <= rows - i; ++space)
                {
                    Console.Write (" ");
                }
                for (int j = i; j <= 2 * i - 1; ++j)
                {
                    Console.Write ("*");
                }
                for (int j = 0; j < i - 1; ++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

    }
}
