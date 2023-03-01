using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Loopassignment
{
    internal class FindSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the n'th no");
            int num=int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                 sum+= i;
            }
            Console.WriteLine("the sum between 1 to "+num+" is "+ sum);
        }
    }
}
