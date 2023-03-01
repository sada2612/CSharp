using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.loops
{//9.	Write a Java program print total number of days in a month 
    internal class DaysCount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("it's program print total number of days in a month ");
            Console.WriteLine("Enter Year");
            int Year=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Month");
            int Month=int.Parse(Console.ReadLine());
            if (Year<0 || Month<0)
            {
                Console.WriteLine("Year and month not vaild try another month year");
            }
            else
            {
                int Days=DateTime.DaysInMonth(Year, Month);
                Console.WriteLine(Days);
            }

        }
    }
}
