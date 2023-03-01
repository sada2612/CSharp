using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.loops
{
    internal class Compound_Interest
    {
        static void Main(string[] args)
        {
           
           
               
                double ci, amount, p, r;
                int n, t;

               
                Console.Write("Enter the principal balance = ");
                p = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter interest rate= ");
                r = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter compound frequency / year = ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the year  = ");
                t = Convert.ToInt32(Console.ReadLine());

               
               
                amount = p * Math.Pow((1 + r / (100 * n)), n * t);

               
                ci = amount - p;

              
                Console.WriteLine("Compound interest = " + Math.Round(ci, 2));

               
                Console.ReadKey();
            







}
    }
}
