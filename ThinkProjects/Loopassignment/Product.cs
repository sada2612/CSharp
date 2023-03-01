using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Loopassignment
{
    internal class Product
    {//Write a  program to calculate product of digits of any number.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number and i give product");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine(num*num*num);
        }
    }
}
