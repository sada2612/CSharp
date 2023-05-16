using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Collection
{
    internal class GenericStackDemo
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
          
            Console.WriteLine($" Poped element => {stack.Pop()}");
            Console.WriteLine($" Peeked element => {stack.Peek()}");
            foreach (var item in stack)
            {
                Console.WriteLine(" Pushed elements => " + item);
            }
        }
    }
}
