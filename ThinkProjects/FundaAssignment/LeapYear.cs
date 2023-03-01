using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.loops
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hii User enter the Year:");
            int Year=int.Parse(Console.ReadLine());
            if (Year%100==0 && Year%100==0 && Year%4==0)
            {
                Console.WriteLine(Year +" it's leap Year");
            }
            else
            {
                Console.WriteLine(Year+" is not leap year");
            }
        }
    }
}
