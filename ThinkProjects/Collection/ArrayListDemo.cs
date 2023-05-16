using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Array.Collection
{
    internal class ArrayListDemo
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 4, 7, 9 };
            ArrayList list= new ArrayList();
            list.Add(1);
            list.Insert(0, 2);
            list.AddRange(a);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.Sort();
           /* list.Reverse();
            list.Remove(1);
            list.RemoveAt(4);
            list.RemoveRange(2,2);*/
        }
    }
}
