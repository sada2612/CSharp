using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Test4
{
    internal class SwapWithoutThred
{
        public static void swap(int a,int b)
        {
            Console.WriteLine(a + " " + b);
            a =a+b;
            b=a-b;
            a=a-b;
            Console.WriteLine(a+" "+b);

        }
        static void Main(string[] args)
        {
            int a = 2; int b=3;
            SwapWithoutThred.swap(a,b); 
        }
}
}
