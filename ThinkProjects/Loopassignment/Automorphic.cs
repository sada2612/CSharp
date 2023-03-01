using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Loopassignment
{
    internal class Automorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("it's automorphic enter the number");
            int num=int.Parse(Console.ReadLine());
            
            if (num>0)
            {
               num *=num;
            }
            Console.WriteLine(num);
        }
    }
}
