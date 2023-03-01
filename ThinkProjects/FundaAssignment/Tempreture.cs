using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.loops
{
    internal class Tempreture
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hii it's temperature converter ");
            double celsius, fahrenheit;
            Console.WriteLine("select converstion \n 1>> celsius to fahrenheit \n 2>> fahrenheit to celsius ");
               int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Please Enter temperature in celsius ");
                celsius = Convert.ToDouble(Console.ReadLine());
                fahrenheit = (celsius * 9) / 5 + 32;
                Console.WriteLine("celsius to  Fahrenheit is = " + fahrenheit);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Please Enter temperature in fahrenheit ");
                fahrenheit = Convert.ToDouble(Console.ReadLine());
                celsius = ((fahrenheit - 32) * 5 / 9);
                Console.WriteLine("Fahrenheit to celsius  is = " + fahrenheit);
            }
            else
            {
                Console.WriteLine("You choose the wrong option");
            }
        }
    }
}
