using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Collection
{
    internal class IcomreableDemo
{
        class student
        {
            public int id { get; set; }
            public string name { get; set; }
        }
        class studCom:IComparer<student>
        {
           

            public int Compare(student x, student y)
            {
                if (x.id>y.id)
                {
                    return 1;
                }else if (x.id == y.id)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }

           
        }
        static void Main(string[] args)
        {
            student stu1 = new student();
            stu1.id = 2;
            stu1.name = "test1";
            student stu2 = new student();
            stu2.id = 1;
            stu2.name = "test2";
           List<student> list = new List<student> { stu1,stu2};

            studCom sc=new studCom();
            list.Sort(sc);
            foreach (student item in list)
            {
                Console.WriteLine( item.id+"  "+item.name);
            }






        }
}
}
