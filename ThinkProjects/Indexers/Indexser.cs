using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Indexers
{
    internal class Indexser
{
        class student
        {
            private int[] stu=new int[3];
            public int this[int index]
            {
                set {
                    stu[index] = value;
                    }
                get { 
                return stu[index];
                }
               
            }
        }
        static void Main(string[] args)
        {
            student stu = new student();
            stu[0] = 2;
            Console.WriteLine(stu[0]);
        }
}
}
