using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Collection
{
    internal class QueueDemo
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            Console.WriteLine("Dqueueed element " + que.Dequeue());
            foreach (var item in que)
            {
                Console.WriteLine(que);
            }

        }
    }
}
