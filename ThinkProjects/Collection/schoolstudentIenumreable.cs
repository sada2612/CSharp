using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThinkProjects.OOPs;

namespace ThinkProjects.Collection
{
    internal class schoolStudentIenumreable
    {
        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        class school:IEnumerable  
        {
            List<Student> Students= new List<Student>();

            public void add(Student s)
            {
                Students.Add(s);
            }

            public IEnumerator GetEnumerator()
            {
               return Students.GetEnumerator(); 
            }
        }
        static void Main(string[] args)
        {
            Student Student1 = new Student();
            Student1.Id = 1;
            Student1.Name= "Test";
            Student Student2 = new Student();
            Student2.Id = 2;
            Student2.Name = "Test2";
            school sc = new();
           
            sc.add(Student2);
            sc.add(Student1);
            foreach (Student item in sc)
            {
                Console.WriteLine(item.Id+"  "+ item.Name);
            }

        }
}
}
