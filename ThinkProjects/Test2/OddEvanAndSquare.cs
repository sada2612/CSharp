using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Test2
{//3.	 WAP to print number from 1 to 50 if number is even then print as it is and number is odd then print its square
    internal class OddEvanAndSquare
    { static void Square()
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("it's Even Number : " + i);
                }
                else
                {
                    int area = (i * i);
                    Console.WriteLine(i + " : square :" + area);

                }
            }
        }
        static void Main(string[] args)
        {
            Square();
        }
    }
}
