using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.loops
{//7.	Write a Java program to input any character and check whether it is alphabet, digit or special character
    internal class CharCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" program to check is alphabet, digit or special character");
            Console.WriteLine("please enter the any char");
            char check = Convert.ToChar(Console.ReadLine());
            if ((check >= 65 && check <= 90)
             || (check >= 97 && check <= 122))
                Console.WriteLine(" Alphabet ");
             else if (check >= 48 && check <= 57)
                Console.WriteLine(" Digit ");
               else
                Console.WriteLine("Special Character");
        }
    }
}
