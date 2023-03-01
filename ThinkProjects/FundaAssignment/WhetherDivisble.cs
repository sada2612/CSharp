using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.loops
{       //2.	Write a Java program to check whether a number is divisible by 5 and 11 or not 
    internal class WhetherDivisble
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the whether number");
                double Wno=Convert.ToDouble(Console.ReadLine());    
            if (Wno%5==0&&Wno%11==0)
            {
                Console.WriteLine(Wno+" is divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine(Wno + " is not divisible by 5 and 11");
            }

        }
    }
}
