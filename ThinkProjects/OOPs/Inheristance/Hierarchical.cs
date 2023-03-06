using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.OOPs.Inheristance
{     

    class Vechicle
    {
       public int twowheelerweel = 2;
      public  int fourwheelerweel = 4;
    }
    class Twowheeler : Vechicle {
        string name = "KTM";
        public Twowheeler() {

            Console.WriteLine("twowheeler name is :"+name+" and present wheels are :"+ twowheelerweel);
        }
    }
    class Fourwheeler : Vechicle {
        string name = "THOR";
       public Fourwheeler() {
            Console.WriteLine("twowheeler name is :" + name + " and present wheels are :" + fourwheelerweel);
        }
    }
    internal class Hierarchical
    {
        static void Main(string[] args)
        {
            Fourwheeler fourwheeler= new Fourwheeler();
            Twowheeler twowheel= new Twowheeler();  
        }
    }
}
