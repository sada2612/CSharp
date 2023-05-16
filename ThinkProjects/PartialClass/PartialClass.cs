using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.PartialClass
{
    internal class PartialClass
{
       partial class student
        {
            public int id { get; set; }
            public string name { get; set; }
        }
        partial class student
        {
           public student() {
                Console.WriteLine("hello User");
            } 
            public void show(string name)
            {
                Console.WriteLine(" "+name);
            }
        }
        static void Main(string[] args)
        {
            student student1 = new student();
            student1.id = 1;
            student1.name = "Test";
            student1.show(student1.name);

        }

    }
}
