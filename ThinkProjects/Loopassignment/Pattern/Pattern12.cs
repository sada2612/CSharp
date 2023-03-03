using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Loopassignment.Pattern
{
    internal class Pattern12
    {
        public static void Main(String[] args)
        {
            char last = 'J', alphabet = 'A';

            
            for (int i = 1; i <= (last - 'A' + 1); ++i)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write(alphabet + " ");
                   
                }
                alphabet++;
                Console.WriteLine();
            }
        }
    }
}
