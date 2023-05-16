using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Parmes
{
    internal class Paramss
    {
        public static int add (params int[]a){

            int sum = 0;
            foreach (int i in a)
            {
                sum += i;
            }
        return sum;
        }
        static void Main(string[] args)
        {
          int result=  Paramss.add(2,5,6,7);
            Console.WriteLine(result);
        }
}
}
