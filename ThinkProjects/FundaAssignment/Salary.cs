using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ThinkProjects.loops
{/*10.	Write a Java program to input basic salary of an employee and calculate its 

    Gross salary according to following: Basic Salary <= 10000 : HRA = 20%, DA = 80% Basic Salary <= 20000 :
    HRA = 25%, DA = 90% Basic Salary >20000 : HRA = 30%, DA = 95% */

    internal class Salary
    {
        static void Main(string[] args)
        {
            Double Basic_Salary, DA, HRA, Gross_Salary;

            Console.Write("Enter Basic Salary : ");
            Basic_Salary = Convert.ToInt32(Console.ReadLine());

            DA = (Basic_Salary * 40) / 100;
            HRA = (Basic_Salary * 20) / 100;
            Gross_Salary = Basic_Salary + DA + HRA;

            Console.Write("\n\nDearness Allowance 40 % of Basic Salary : " + DA);
            Console.Write("\nHouse Rent 20 % of Basic Salary : " + HRA);
            Console.Write("\nGross Salary : " + Gross_Salary);
        }
    }
}
