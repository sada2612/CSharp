using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Array
{
    internal class OddNumbers
    {
       
        static void Odd(int[] arr)
        {
            for (int i = 0; i < arr.Length;i++)
            {
                if (arr[i]%2!=0)    
                {
                    Console.WriteLine("Odd numbers" + arr[i]);
                }
            }
        }
        //wap to display odd num from the array
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of Arr");
            int len=int.Parse(Console.ReadLine());
           int[] arr=new int[len];
            Console.WriteLine("Enter the element of array");
            for (int i = 0; i <arr.Length; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }

            Odd(arr);
        }
    }
}
