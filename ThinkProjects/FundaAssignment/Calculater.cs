using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.loops
{//5.	Write a Java program to create Simple Calculator  
    internal class Calculater
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hii user it's calculater program");
            Console.WriteLine("please enter the first number");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("please select operation \n 1>> addition \n 2>> Sub \n 3>> Mul \n 4>> div");
            int opreation = int.Parse(Console.ReadLine());
            switch (opreation)
            {
                case 1: Console.WriteLine(num1+num2);
                    break;
                case 2:
                    Console.WriteLine(num1 - num2);
                    break;
                case 3:
                    Console.WriteLine(num1 * num2);
                    break;
                case 4:
                    Console.WriteLine(num1 / num2);
                    break;
                default:
                    break;
            }

        }
    }
}
