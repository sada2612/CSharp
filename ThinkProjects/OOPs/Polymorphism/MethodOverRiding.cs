using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.OOPs.Polymorphism
{
    class Perent
    {
        public virtual void Run()
        {
            Console.WriteLine("it's Parent Class Method");

        }
    } 
    class Child : Perent
    {
        public override void Run() => Console.WriteLine("it's child class method");

    } 
    internal class MethodOverRiding
    {

        static void Main(string[] args)
        {
            Perent c = new Child();
            c.Run();
          
        }
    }
}
