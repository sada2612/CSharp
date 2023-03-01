using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Loopassignment
{//2.	Write the program  to display the first ten terms of the following series:1, 4, 9, 16,


    internal class Oddterms
    {
        static void Main(string[] args)
        {
            int n, i = 1;
            Console.WriteLine("enter the endpoint");
            n=int.Parse(Console.ReadLine());
            while (i<=n)
            {
                Console.WriteLine(i*i);
                i++;
            }
        }
    }
}
