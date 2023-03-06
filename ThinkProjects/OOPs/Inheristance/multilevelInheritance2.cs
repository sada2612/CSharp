using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.OOPs.Inheristance
{  
    class Food
    {
       public string foodstring = "Everyone is eating a food";
    }
    class Pizza : Food
    {
       public string feat = "Pizza";
    }
    class Coca : Pizza
    {
        string seat = "Coca";
        public void display()
        {
            Console.WriteLine(foodstring+" 1 product : "+feat+" 2 product"+seat);
        }
    }
    internal class multilevelInheritance2
    {

        static void Main(string[] args)
        {
            Coca c = new Coca();
            c.display();
        }
    }
}
