using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.BoxingAndUnboxing
{
    internal class BoxUnbox
{
        static void Main(string[] args)
        {
            int obj = 3;
            Console.WriteLine(obj.GetType());
            object num = obj;
            Console.WriteLine(num.GetType()); 
        }
}
}
