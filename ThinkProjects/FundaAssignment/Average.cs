using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.loops
{            //2.	Write a program to enter marks of five subjects and calculate total, average and percentage
    internal class Average
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hii Student Please Enter Your Marks Details");
            Console.WriteLine("English");
            int English=int.Parse(Console.ReadLine());
            Console.WriteLine("Javascript");
            int Js = int.Parse(Console.ReadLine());
            Console.WriteLine("C");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine("Java");
            int Java = int.Parse(Console.ReadLine());
            Console.WriteLine("asp.net");
            int asp = int.Parse(Console.ReadLine());
            Console.WriteLine("please Select Your Opreation");
            Console.WriteLine(" 1>> Total \n 2>> Average \n 3>> Percentage");
            int choice = int.Parse(Console.ReadLine());
            int sum = English + C + Java + asp + Js;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Your Marks Total Is"+sum);
                    break;
                case 2:
                    Console.WriteLine("Your Marks Avreage Is" + sum/5);
                    break;
                case 3:
                    Console.WriteLine("Your Marks Percentage Is " + (sum*100)/500);
                    break;
                default:
                    Console.WriteLine("Your Opreation Is Not Vaild");
                    break;
            }
        }
    }
}
