using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.OOPs.Inheristance
{
    class dog
    {
        public int  legs=4;
    }
    class tomy : dog {
        string gender = "male";
    public tomy()
        {
            Console.WriteLine("tomys gender is :"+gender+" \ntomys legs s : "+legs);
        }
    }
    internal class SingleInheritance
    {
        static void Main(string[] args)
        {
            tomy tomy = new tomy();
        }
    }
}
