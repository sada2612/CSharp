using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.loops
{//4.	Write a Java program to input any alphabet and check whether it is vowel or consonant 
    internal class Vowals
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hii User it's program check the input is vowel or consonant");
            Console.WriteLine(" Enter any alphabet");
            string input = Console.ReadLine();
            if (input == "a" || input == "e"|| input == "i" || input == "o" || input == "u")
            {
                Console.WriteLine(input+" is a Vowal");
            }
            else
            {
                Console.WriteLine(input+ " is a consonant");
            }
        }
    }
}
