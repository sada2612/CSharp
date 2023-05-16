using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Collection
{
    internal class GenericQueueDemo
    {
        static void Main(string[] args)
        {
            int[] a = { 6, 7, 8, 9 };
            Queue<int> sl = new Queue<int>();

            sl.Enqueue(1);
            sl.Enqueue(2);
            sl.Enqueue(3);
            sl.Enqueue(4);
          

            foreach (int item in sl)
            {
                Console.WriteLine("All Enqueue elements => " + item);
            }

            Console.WriteLine("Dqueueed element " + sl.Dequeue());
            Console.WriteLine("Peeked  element " + sl.Peek());








        }
    }
}
