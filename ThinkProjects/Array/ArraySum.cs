
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Array
{
    internal class ArraySum
    {
        //wap to sum of array element  using array
        static void Main(string[] args)
        {
            int sum = 0;
            int[] num = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < num.Length; i++)
            {
                sum = sum + num[i];
            }
            Console.WriteLine(sum);
        }
    }
}
