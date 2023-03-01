using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.loops
{// program to check whether a number is even or
    internal class OddEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" program to check whether a number is even or odd");
            Console.WriteLine(" please enter the any number");
            int num=int.Parse(Console.ReadLine());
            if (num%2==0)
            {
                Console.WriteLine(num +" is even");
            }
            else
            {
                Console.WriteLine(num+" is odd");
            }
        }
    }
}
