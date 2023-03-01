using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.loops
{//6.	Write a Java program to check whether a number is negative, positive or zero 
    internal class PositiveOrNegetive
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" it's program to check whether a number is negative, positive or zero ");
            Console.WriteLine(" please enter the number");
            int num=int.Parse(Console.ReadLine());
            if (num>0)
            {
                Console.WriteLine(num+ " is positive ");
            }else if (num==0)
            {
                Console.WriteLine(num + " is zero");

            }
            else
            {
                Console.WriteLine(num + " is negetive");
            }
        }
    }
}
