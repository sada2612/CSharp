using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Loopassignment
{
    internal class Palendrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("it's paliendrome program please emter the number");
            int num=int.Parse(Console.ReadLine());
            int rev = 0, temp=num, rem;
           while(num > 0) {
                rem = num % 10;
                rev = rev * 10 + rem;
                num= num / 10;
            
            }
            if (rev==temp)
            {
                Console.WriteLine("its palendrome");
            }
            else
            {
                Console.WriteLine("not pelendrome");
            }

        }
    }
}
