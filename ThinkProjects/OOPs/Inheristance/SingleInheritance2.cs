using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.OOPs.Inheristance
{  class Company
    {
       public static string Cname = "raj.pvt";
    }
    class Employe : Company {
       public string name = "sahadev";
        public void display()
        {
            Console.WriteLine("Company Name : "+Cname+" Emp name : "+name);
        }
    }
    internal class SingleInheritance2
    {
        static void Main(string[] args)
        {
            Employe e=new Employe();
            e.display();
        }
    }
}
