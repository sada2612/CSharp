using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Array
{
    internal class PrimeArray
    {
        static void Prime(int[] arr)
        {
            int j;

            for (int i = 0; i < arr.Length; i++)
            {


                for (j = 2; j < arr[i]; j++)
                    if ((arr[i] % j == 0))
                    {

                        Console.WriteLine(arr[i]+" Is NOT a primenumber");
                        break;
                    }
                if (j == arr[i])
                {
                    Console.WriteLine(arr[i]+" Is a primenumber");

                }

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of Array");
            int len = int.Parse(Console.ReadLine());
            int[] arr = new int[len];
            Console.WriteLine("Enter the element of array");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Prime(arr);

        }
    }
}
