using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Structure
{
    internal class STUDENTsTRUCT
{
        struct MyStruct
        {
            public MyStruct() {

                Console.WriteLine(  "Hii user");
            }
        }
        static void Main(string[] args)
        {
            MyStruct s1=new MyStruct();
        }
    }
}
