using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.loops
{      //3.	Write a Java program to find maximum between three numbers 
    internal class Max
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hii user it's find max program");
            Console.WriteLine("please Enter first number ");
            int Number1=int.Parse(Console.ReadLine());
            Console.WriteLine("please Enter second number ");
            int Number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("please Enter third number ");
            int Number3 = int.Parse(Console.ReadLine());
            if (Number1>Number2 && Number1>Number3)
            {
                Console.WriteLine(Number1+" is the max");
            }else if (Number2>Number1 && Number2>Number3)
            {
                Console.WriteLine(Number2+" is the max");
            }
            else
            {
                Console.WriteLine(Number3+" is the max");
            }


        }
    }
}
