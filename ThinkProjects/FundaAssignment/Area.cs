using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.loops
{                 //1.	Write a program to calculate area of an equilateral triangle.
    internal class Area
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your trangle hight");
           int Hight=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your trangle Base");
            int Base = int.Parse(Console.ReadLine());

            if (Hight<=0 || Base<=0)
            {
                Console.WriteLine("Our value are not vaild");
            }
            else
            {
                Console.WriteLine("Area of trangle is = "+(Base*Hight)/2);
            }


        }
    }
}
