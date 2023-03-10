using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Array
{
    internal class SearchArray
    {
        static bool Search(int[] arr,int input)
        {
            bool res = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==input)
                {
                     res= true;
                }
                else
                {
                    res = false;
                }
            }
            return res; 
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

            Console.WriteLine("Enter checking input is presnt or not");
            int input=int.Parse(Console.ReadLine());


          bool res=  Search(arr,input);
            if (res)
            {
                Console.WriteLine("number is present");
            }
            else
            {
                Console.WriteLine("number is not present");
            }
        }
    }
}
