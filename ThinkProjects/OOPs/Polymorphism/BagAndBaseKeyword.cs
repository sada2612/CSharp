using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.OOPs.Polymorphism
{
        class Bag
    { string BrandName;
        string Color ;
        int Price;
        Pen pen;
        Nib nib;
        public Bag(string BrandName,string Color,int Price,Pen pen,Nib nib)
        {
            this.BrandName = BrandName;
            this.Color = Color;
            this.Price = Price;
            this.pen = pen;
            this.nib= nib;


        }
        public void display()
        {

            Console.WriteLine("bag brandname is :" + BrandName + "Bag color is : " + Color + "Bag price is : " + Price);
            pen.show();
            nib.Shownib();


        }

        
    }
   
    class Pen
    {
        string PenName ;
        string PenType ;
        int Price ;
        public Pen(string PenName,string PenType,int Price)
        {
            this.PenType = PenType;
            this.PenName = PenName;
            this.Price = Price;

        }
        public void show()
        {
            Console.WriteLine("pen name is : " + PenName + " Pen type is :" + PenType + " pen Price is :" + Price);
            
        }
       
    }
    class Nib
    {
        string type;
        int price;
        public Nib(string type, int price)
        {
            this.type = type;
            this.price = price;
        }
        public void Shownib()
        {
            Console.WriteLine("nibtype is : " + type + "Nib price is : " + price);
        }
    }
    internal class BagAndBaseKeyword
    {
        static void Main(string[] args)
        {
            Pen p = new Pen("renold", "ballpen", 120);
            Nib n = new Nib("ring", 50);
            Bag b = new Bag("sky", "red", 500, p, n);
            b.display();

        }
}
}
