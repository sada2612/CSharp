using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Loopassignment
{//10.	.WAP to print table of given no
    internal class Table
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter no i give table of that table:");
            int num=int.Parse(Console.ReadLine());
            int table = 0;
            do {
                Console.WriteLine(table+=num);
             
            }while(table <= num*9);
           
        }
    }
}
