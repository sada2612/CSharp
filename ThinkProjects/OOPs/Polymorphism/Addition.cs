using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.OOPs.Polymorphism
{  abstract class First
    {
        public int a = 10;
        public abstract void Add(int a,int b);
    }
    interface ISecondable
    {
        static int b = 28;
        public void Add(int a,int b);
    }
    class Additionprogram : First, ISecondable
    {
        public override void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }


    class Addition
    {
        static void Main(string[] args)
        {

            Additionprogram a1=new Additionprogram();
          a1.Add(1,2);

        }
        
      
    }
}
