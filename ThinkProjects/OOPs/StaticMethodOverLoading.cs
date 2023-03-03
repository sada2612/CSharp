using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.OOPs
{
    internal class StaticMethodOverLoading
    {//wap to show overloading of static method.
        public static void InputTypeCheck()
        {
            Console.WriteLine("you not Passed parameter");
        }
        public static void InputTypeCheck(int type)
        {
            Console.WriteLine("your passed input datatype is int : "+type);
        }
        public static void InputTypeCheck(string type) 
        {
            Console.WriteLine("your passed input datatype is string : " + type);
        }
        public static void InputTypeCheck(bool type)
        {
            Console.WriteLine("your passed input datatype is bool : " + type);
        }
        public static void InputTypeCheck(float type)
        {
            Console.WriteLine("your passed input datatype is float : " + type);
        }
        public static void InputTypeCheck(long type)
        {
            Console.WriteLine("your passed input datatype is  long  :" + type);
        
        }
       
        static void Main(string[] args)
        {
           
            InputTypeCheck("name");
        }
    }
}
