using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.OOPs
{
    internal class Car
    {
        string ModelNo;
        string name;
        string color;
        int price;
       
        static void Main(string[] args)
        {
           Car tata= new Car();
            tata.ModelNo = "mp123";
            tata.name = "tata";
            tata.color = "red";
            tata.price = 100;

            Car ashok = new Car();
            ashok.ModelNo = "mp11123";
            ashok.name = "ashok";
            ashok.color = "blue";
            ashok.price = 200;

            Car swift = new Car();
            swift.ModelNo = "kp11123";
            swift.name = "suziki";
            swift.color = "green";
            swift.price = 400;
            Console.WriteLine("its first object car : "+tata.ModelNo+" - "+tata.name+" - "+tata.color+" - "+tata.price);
            Console.WriteLine("its first object car : " + ashok.ModelNo + " - " + ashok.name + " - " + ashok.color + " - " + ashok.price);
            Console.WriteLine("its first object car : " + swift.ModelNo + " - " + swift.name + " - " + swift.color + " - " + swift.price);
        }
    }
}
