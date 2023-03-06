using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.OOPs.Polymorphism
{
    internal class ContructerOverLoading
    {
        public ContructerOverLoading()
        {

            Console.WriteLine("hii it's defualt contructer and as well as no aregument/parameterless contructer");
        }
        public ContructerOverLoading(string Name)
        {
            Console.WriteLine("Hii " + Name + " it's parametrised contructruter hi countain the string parameter");
        }
        public ContructerOverLoading(int age)
        {
            Console.WriteLine("Hii your is  " + age + " it's parametrised contructruter hi countain the int parameter");
        }
        static void Main(string[] args)
        {
            ContructerOverLoading CV = new ContructerOverLoading();
            ContructerOverLoading CV1 = new ContructerOverLoading("sahadev");
            ContructerOverLoading CV2 = new ContructerOverLoading(23);
        }
    }
}
