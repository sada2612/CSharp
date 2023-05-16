
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Test4
{
    internal class AdditionisSevenOrNot
{
        public static bool Add7OrNot(int[]a)
        {
            if (a.Length < 1) { return false; }
            for (int i = 0; i < a.Length; i++)
            {
                for (int k = 1; k < a.Length; k++)
                {
                    if (a[i] + a[k]==7)
                    {
                        Console.WriteLine(a[i] + " , " + a[k]);
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            AdditionisSevenOrNot.Add7OrNot(a);
        }
}
}
