using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Collection
{
    internal class HashSetDemo
    {
        static void Main(string[] args)
        {
            HashSet<int> hash2 = new HashSet<int>(){ 1,2,3,4,5,6,7};

            HashSet<int> hash = new HashSet<int>() { 1,3,5,7,8,12,34};
           hash2.UnionWith(hash);
            foreach (int item in hash2)
            {
                Console.WriteLine("UnionWith method" + item);
            }
          /*  hash2.ExceptWith(hash);
            foreach (int item in hash2)
            {
                Console.WriteLine("ExceptWith method" + item);
            }
            hash2.IntersectWith(hash);
            foreach (int item in hash2)
            {
                Console.WriteLine("IntersectWith method" + item);
            }*/





        }
    }
}
