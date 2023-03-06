using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Test2
{
    internal class Facters
    {//2.	Write a program to print all factors of given numbers
        static void factersnum(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num%i==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("please Enter the number");
            int num = int.Parse(Console.ReadLine());
            factersnum(num);
        }
    }
}
