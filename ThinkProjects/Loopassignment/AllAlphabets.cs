using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Loopassignment
{
    internal class AllAlphabets
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All Alphabets");
            char ch;
            for (ch = 'a';ch  <= 'z'; ch++)
            {
                Console.Write(""+ch);
            }
        }
    }
}
