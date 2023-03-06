using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ThinkProjects.Test2;

namespace ThinkProjects.Test2
{//4.	WAP to print fibbo series upto 20 terms
    internal class FibooTerm20
    {
        public void fibbo()
        {
            int sum = 0;
            
            for (int i = sum; i <= 20; i++)
            {
                sum+= i;
                Console.WriteLine(sum);

            }
           

        }
        static void Main(string[] args)
        {
    FibooTerm20 ft=new FibooTerm20();
    ft.fibbo();
        }
    }
}
