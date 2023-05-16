using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Array.Collection
{
    internal class StackDemo
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            Console.WriteLine("pped elemment is " + stack.Pop());
            Console.WriteLine("peeked element is " + stack.Peek());
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

        }
    }
}
