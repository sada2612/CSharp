using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.OOPs.Polymorphism
{
    abstract class Test1
    {
        public abstract void Show();
       
    }
    abstract class Test2 : Test1 {

        public abstract void Run();

    } 
    class Result : Test2
    {
        public override void Show() {
            Console.WriteLine("it's Show method");
        }
        public override void Run() {
            Console.WriteLine("it's run method");
        }  

    }
    internal class AbstractExample
    {
        static void Main(string[] args)
        {
            Result r1= new Result();
            r1.Show();
            r1.Run();
        }
    }
}
