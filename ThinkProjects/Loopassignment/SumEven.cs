using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Loopassignment
{//3.	Write a program to print all alphabets from a to z. - using  for loop
    internal class SumEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please mention the endnumber of even");
            int length=int.Parse(Console.ReadLine());
            int Sum = 0;
            for (int i = 0;i <length; i++)
            {
                if (i%2==0)
                {
                    Sum += i;
                }
            }
            Console.WriteLine(Sum);
        }
    }
}
