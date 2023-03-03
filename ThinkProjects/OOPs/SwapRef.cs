using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThinkProjects.loops;

namespace ThinkProjects.OOPs
{   
   //swap program using multiple methods using ref
    
    internal class SwapRef
    {

        public void Swap(ref int num1,ref int num2){
            int temp = num1;
            num1 = num2;
            num2 =temp;
            Console.WriteLine("in method :"+num1+" , "+num2);
        }    
        static void Main(string[] args)
        {
            SwapRef s1=new SwapRef();
            Console.WriteLine("Enter the 1st Number");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 1st Number");
            int num2=int.Parse(Console.ReadLine());
            Console.WriteLine("Before Swap :"+num1+" , "+num2);
            s1.Swap(ref num1,ref num2);
            Console.WriteLine("After the Swap : "+num1+" , "+num2);

        }
    }
}
