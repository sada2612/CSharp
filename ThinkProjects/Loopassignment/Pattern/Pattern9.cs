using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Loopassignment.Pattern
{
    internal class Pattern9
    {
        public static void Main(String[] args)
        {
            int rows = 7, number = 1;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number + " ");
                    ++number;
                }
                Console.WriteLine(); 
            }
        }

    }
}
