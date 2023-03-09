using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.OOPs.Polymorphism
{
    interface IA1
    {
        public abstract void Test();

    }
    interface IB1 : IA1 {

        public abstract void Test2();
    }
    class TestResult:IB1
    {
        public void Test()
        {
            Console.WriteLine("it's first Test method");
        }

        public void Test2()
        {
            Console.WriteLine("it's second Test Method");
        }
    }
    class Interfacetest
    {
        static void Main(string[] args)
        {
            TestResult TR= new TestResult();    
            TR.Test();
            TR.Test2();
        }
    }
}
