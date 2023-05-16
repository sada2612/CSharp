using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.MultiThreding;

    internal class therddemo1
{

    public void Task1()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }
}
    public void Task2() {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i+" Task 2");
        }
    }

    static void Main(string[] args)
    {
        therddemo1 t1= new therddemo1();
        Thread th1 = new Thread(new ThreadStart(t1.Task1));
        Thread th2 = new Thread(new ThreadStart(t1.Task2));
        th2.Start();
        th1.Start();

    }
}

