using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Collection
{
    internal class GenericClass
    {
        class CustomGenericClass<Type>
        {
            public Type Data;
            public void Add(Type data)
            {
                this.Data = data;
            }
            public Type Display()
            {
                return Data;
            }

          
        }
            static void Main(string[] args)
        {
            CustomGenericClass<int> GS = new CustomGenericClass<int>();
            GS.Add(1);
           
            Console.WriteLine(GS.Display());
        }
    }
}
