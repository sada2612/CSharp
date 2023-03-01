using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Loopassignment
{
    internal class Nterm1
    {//5.	Print Series 1  11  111  111……..n terms
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter the end number");
            int num = int.Parse(Console.ReadLine());
            int i, s = 0;
            for ( i = 1; i <= num; i++)
            {
                s = (s * 10) + 1;
                Console.WriteLine(s+" ");
            }
           
        }
    }
}
