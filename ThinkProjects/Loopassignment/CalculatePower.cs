using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Loopassignment
{//11.	WAP to accept base and index from user and calculates power
    internal class CalculatePower
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base");
            int Base = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the index");
            int index=int.Parse(Console.ReadLine());
            double result =Math.Pow(Base, index);
            Console.WriteLine(result);
        }
    }
}
