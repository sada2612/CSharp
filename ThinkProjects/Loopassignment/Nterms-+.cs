using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Loopassignment
{//4.	Print Series 2 -4 6 -8………n terms
    internal class Nterms__
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter end number");
            int num=int.Parse(Console.ReadLine());
           
            for (int i = 1; i <= num; i++)
            {
               
                if (i%2==0)
                {
                    int j = -(i);
                    Console.WriteLine(j);
                }
            }
          
           
        }
    }
}
