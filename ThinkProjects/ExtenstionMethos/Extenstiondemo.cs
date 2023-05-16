using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.ExtenstionMethos
{
    internal class Extenstiondemo
{
        public class Clac
        {
            public int Add(int a, int b)
            {
                return a + b;
            }
            public int Sub(int a, int b)
            {
                return a - b;
            }

            internal bool Multiply(int v1, int v2)
            {
                throw new NotImplementedException();
            }
        }


        // extension method
        public static class Test // 1 static class
        {
            //2 static method         3 parameter will be the ref of the class
            //public static int Multiply(this Clac c, int x, int y) => x * y;
        }
        public class Program
        {

            static void Main(string[] args)
            {
                //Clac clac = new Clac();
                //Console.WriteLine(clac.Add(45, 67));
                //Console.WriteLine(clac.Sub(56, 23));
                //Console.WriteLine(clac.Multiply(22, 67));
            }
        }
    }



}

