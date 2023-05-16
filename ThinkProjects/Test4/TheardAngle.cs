using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Test4
{
    internal class TheardAngle
{
        static void Main(string[] args)
        {
            Console.WriteLine(  "enter the first angle1");
            int angle1=int.Parse( Console.ReadLine() );
            Console.WriteLine("enter the first angle2");
            int angle2 = int.Parse(Console.ReadLine());
            int angle3=180-(angle1 + angle2);
            Console.WriteLine( angle3+"  Angle3");

        }
}
}
