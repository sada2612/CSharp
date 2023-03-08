using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.OOPs.Polymorphism
{
    internal class BaseKeyword
    {
        class Hotel
        {
            string Hotel_Name = "Sahyadri";
            internal int Hotel_Capecity = 400;
            public void Run()
            {
                Console.WriteLine(" Hii it's " + Hotel_Name+" Hotel  ");
            }

        }
        class Employe : Hotel
        {
            string Hotel_EmployeName = "raj";
            int Hotel_EmployeAge = 19;
            public void Run()
            {
                base.Run();


                Console.WriteLine(" Hotel Capecity is "+base.Hotel_Capecity+" Employe Name : "+this.Hotel_EmployeName+" Employe age is :"+this.Hotel_EmployeAge);
            }
           

        }
        static void Main(string[] args)
        {
            Employe e1=new Employe();
            e1.Run();
        }
    }
}
