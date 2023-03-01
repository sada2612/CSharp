using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ThinkProjects.loops
{/*11.	Write a Java program to input electricity consumption unit and calculate totalelectricity billaccording to the
  * given condition: For first 50 units Rs. 0.50/unit For next 100 units Rs. 0.75/unit For next 100 units Rs. 1.20/unit 
  * For unit above 250 Rs. 1.50/unit An additional surcharge of 20% is added to the bill */
    internal class ElectricityBill
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please Enter the Electricity bill");
            double units=Convert.ToDouble(Console.ReadLine());
            if (units <= 100)
            {
                Console.WriteLine(units * 10);
            }
            else if (units <= 200)
            {
                Console.WriteLine((100 * 10) +
                       (units - 100) * 15); 
            }
            else if (units <= 300)
            {
                Console.WriteLine((100 * 10) +
                       (100 * 15) +
                       (units - 200) * 20); 
            }
            else if (units > 300)
            {
                Console.WriteLine((100 * 10) +
                       (100 * 15) +
                       (100 * 20) +
                       (units - 300) * 25); 
            }
        }
    }
}
