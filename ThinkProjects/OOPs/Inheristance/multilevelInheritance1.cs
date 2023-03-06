using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.OOPs.Inheristance
{  
     class Animal
    {
       public string eat = " animal eat both veg or non-veg";
    }class Cat:Animal
    {
        public int catlegs = 4;
    }class Name :Cat
    {
        public string name = "alexa";
       public Name()
        {

            Console.WriteLine(eat+" My cat name is "+name+" Cat have "+catlegs+"legs ");
        }
    }
    
        
        
        
        class multilevelInheritance1
    {
        static void Main(string[] args)
        {
            Name name= new Name();
        }
    }
}
