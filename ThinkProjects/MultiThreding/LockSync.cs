using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.MultiThreding
{
    internal class LockSync
    {
        public void Task1()
        {
            lock(this);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void Task2()
        {
            lock (this) ;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + " Task 2");
            }
        }

        static void Main(string[] args)
        {
            LockSync t1= new LockSync();
            Thread th1=new Thread(new ThreadStart(t1.Task1));
            Thread th2 = new Thread(new ThreadStart(t1.Task2));
            th1.Start();
            th2.Start();
        }
}
}
