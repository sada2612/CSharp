using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThinkProjects.loops;

namespace ThinkProjects.OOPs
{
    internal class AreaMethods
    {
        // wap to overload area method to calaulate the area of retangle ,circle ,square and trangle.

         
        public void CalculateArea(int Rectandlelength, double rectangleBredth)
        {// calaulate the area of rectangle
            Console.WriteLine("Area of rectangle is :"+(Rectandlelength* rectangleBredth));
        }
        public void CalculateArea(double redius)
        {// calaulate the area of circle
            double area = Math.PI * redius * redius;

            Console.WriteLine("Area of circle is :" + (area));
        }
        public void CalculateArea(int Base,int Height)
        {// calaulate the area of trangle
            int area = (Base * Height) / 2;

            Console.WriteLine("Area of trangle is :" + (area));
        }
        public void CalculateArea(int Area)
        {// calaulate the area of square
            int area = Area * Area;

            Console.WriteLine("Area of square is :" + (area));
        }

        static void Main(string[] args)
        {
            AreaMethods areaMethods= new AreaMethods();
            Console.WriteLine("Please select the Opreation");
            Console.WriteLine(" 1 >> Area of circle \n 2 >> Area of trangle \n 3 >> Area of Square \n 4 >> Area of Rectangle ");
            int UserRes=int.Parse(Console.ReadLine());
            switch (UserRes)
            {
                case 1:Console.WriteLine("please Enter redius of circle in Double");
                    double Area=Convert.ToDouble(Console.ReadLine());
                    areaMethods.CalculateArea(Area);
                    break;
                 case 2: Console.WriteLine(  );
                    Console.WriteLine("please Enter Base of trangle");
                    int Base = int.Parse(Console.ReadLine());
                    Console.WriteLine("please Enter Height of trangle");
                    int Height = int.Parse(Console.ReadLine());
                    areaMethods.CalculateArea(Base,Height);
                    break;
                    case 3: Console.WriteLine("Enter the Area of Square");
                      int area=int.Parse(Console.ReadLine());   
                      areaMethods.CalculateArea(area);
                      break;
                      case 4: Console.WriteLine("Enter the length of rectrangle in integer"); 
                      int length=int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the bredth  of rectrangle in double");
                    double bredth=Convert.ToDouble(Console.ReadLine());     
                    areaMethods.CalculateArea(length, length);
                    break;
            }
        }
    }
}
