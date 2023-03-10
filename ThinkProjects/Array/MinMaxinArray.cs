using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Array
{
    internal class MinMaxinArray
    {
        static void Max(int[] arr) {
            int MaxValue = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (MaxValue < arr[i])
                {
                    MaxValue = arr[i];
                }
            }
            Console.WriteLine(MaxValue);
        
        }
        static void Min(int[] arr)
        {
            int MaxValue = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (MaxValue > arr[i])
                {
                    MaxValue = arr[i];
                }
            }
            Console.WriteLine(MaxValue);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of Arr");
            int len = int.Parse(Console.ReadLine());
            int[] arr = new int[len];
            Console.WriteLine("Enter the element of array");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Max(arr);
            Min(arr);
           
        }
    }
}
