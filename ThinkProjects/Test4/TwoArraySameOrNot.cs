using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Test4
{
    internal class TwoArraySameOrNot
{
        public static bool ArrayChack(int[] a,int[] b)
        {
            if(a.Length != b.Length)
            { return false; }
            for (int i = 0; i < a.Length; i++)
            {
               bool res= a[i] != b[i];
                if (res)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, };
            int[] array2 = { 1,2, 3, 4 };
          bool result=  TwoArraySameOrNot.ArrayChack(array1, array2);
            if (result)
            {
                Console.WriteLine( "Both array are Same");
            }
            else
            {
                Console.WriteLine( " Both array are Diffrent");
            }
        }
}
}
