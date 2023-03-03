using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Loopassignment.Pattern
{
    internal class Pattern3
    {
        public static void Main(String[] args)
        {
            int rows = 5, k = 0;
            for (int i = 1; i <= rows; ++i,k=0)
            {
                for (int space = 1; space <= rows - i;space++)
                {
                    Console.Write (" ");
                }
                while (k != 2 * i - 1)
                {
                    Console.Write ("* ");
                    ++k;
                }
                Console.WriteLine ();
            }
        }
    }
}
