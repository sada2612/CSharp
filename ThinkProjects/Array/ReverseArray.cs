using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Array
{
    internal class ReverseArray
    {
        static void Rev(int[] arr)
        {
            int temp = 0;
            int j=arr.Length-1;
            for (int i = 0; i < arr.Length; i++)
            {
              temp= arr[i];
                arr[i] = arr[j];
                arr[j]=temp;
                j--;
            }
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
            Rev(arr);
        }
    }
}
