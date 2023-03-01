using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.OOPs
{
    internal class Employe
    {
        int id = 1;
        string name = "sahadev";
        int salary = 20000;

        static void Main(string[] args)
        {
             Employe emp1= new Employe();
            Console.WriteLine(emp1.id+" \n"+ emp1.name + " \n"+ emp1.salary + " \n");
        }
    }
}
