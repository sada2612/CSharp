using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Loopassignment
{
    internal class SumOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please mention the endnumber of even");
            int length = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                
                if (i%2!=0)
                {
                    sum += i;
                   
                }
               
            }
            Console.WriteLine(sum);
        }
    }
}
