using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Loopassignment
{//8.	Write a program to find frequency of each digit in a given integer.
    internal class Frequency
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digit frequency");
            Console.WriteLine("Enter any number ");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Digit i give you Frequency");
            int digit=int.Parse(Console.ReadLine());
            int count = 0;
           
            while(num>0)
            {
              if  (num % 10 == digit)  count += 1 ;
               num=num / 10;
               

            }
            Console.WriteLine(count);

        }
    }
}
