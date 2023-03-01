using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Loopassignment
{
    internal class PrimeNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("it's Prime Numbers between 300 to 400");
            for (int i = 300; i <=400; i++)
            {
                int Count = 0;
                for (int j = 2; j < i/2; j++)
                {
                    if (i%j==0)
                    {
                        Count++;
                    }
                   
                }
                if (Count==0 && i!=1)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
