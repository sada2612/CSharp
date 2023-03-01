using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.OOPs
{//wap to create student class with id , name ,three subject marks,create method to accept
 //details of student and second method calculate percentage of 3 subject third method print all details
 //of student with % put this in main class
    class StudentDeatils
    {
        static int marks(int sub1, int sub2, int sub3)
        {
            int sum = sub1 + sub2 + sub3;
            int per = (int)(0.5f + ((100f * sum) / 300));

            return per;
        }

        static void fulldetails(int id, string name, int per)
        {
            Console.WriteLine(id + " - " + name + " - " + per);
        }



        static void Main(string[] args)
        {
            Console.WriteLine("please enter Student details:");
            Console.Write("Enter the Id : "); int id = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Enter the Name : "); string name = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Enter the C# Subject Marks : "); int sub1 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Enter the Asp.Net Subject Marks : "); int sub2 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Enter the Mysql Subject Marks : "); int sub3 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            int per = marks(sub1, sub2, sub3);
            fulldetails(id, name, per);

        }
    }
}
