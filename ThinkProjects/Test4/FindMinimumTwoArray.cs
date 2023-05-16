using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Test4
{
    internal class FindMinimumTwoArray
    {
        public static int Min(int[,] a)
        {
          int  MinMum = a[0,0];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (a[i,j]<MinMum)
                    {
                        MinMum = a[i, j];
                    }
                }
            }
           return MinMum;

        }
        static void Main(string[] args)
        {
           
            int[,] array =new int[2,2]{ { 5, 3 }, { 2, 5 } };

           int result= FindMinimumTwoArray.Min(array);
            Console.WriteLine(result);
        }

       
    }
}
