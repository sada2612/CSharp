using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Array
{
    internal class CharArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Length of Array");
            int len=int.Parse(Console.ReadLine());
            char[] arr= new char[len];
            Console.WriteLine("Enter the charcter ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToChar(Console.ReadLine());
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine(string.Join(" ",arr));


        }
    }
}
