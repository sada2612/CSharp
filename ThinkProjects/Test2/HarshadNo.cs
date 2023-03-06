using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Test2
{//5.	To find whether the given number is a Harshad number or not, calculate the sum of the digit of the number then, check
 //whether the given number is divisible by the sum of its digit. If yes, then given number is a Harshad number.
    internal class HarshadNo
    {
      
      
      
        public void harshadisYesOrNot(int num)
        {
            int sum = 0;
            while (num>0)
            {
                sum+= num % 10;
                num /= 10;
            }
            if (num%sum==0)
            {
                Console.WriteLine("it's hardshad number");
            }
            else
            {
                Console.WriteLine("it's not a harshad number");
            }

           
        }
        static void Main(string[] args)
        {
            HarshadNo h1 = new HarshadNo();
           h1.harshadisYesOrNot(120);
           
        }
    }
}
