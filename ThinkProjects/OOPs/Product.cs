using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.OOPs
{
    public class Product
    {
        
            string name = "car";
            int price = 300000;
            int Quantity = 5;
            int Sellprice = 280000;
          

        static void QuantityCheck(int OrderQuantity,int fixQuantity) {
           
            int remaning = fixQuantity - OrderQuantity;
            if (OrderQuantity > fixQuantity)
            {
                Console.WriteLine(" Sorry ,Product stock is Limited"+"\n reaminig stock is: "+ fixQuantity+" please enter below "+fixQuantity);
            }
            else
            {
                Console.WriteLine(OrderQuantity+" car order is in stock and  "+remaning + " Stock Remaining");
            }
        
        }

        
        static void Main(string[] args)
        {
           
            Product Productdeatils=new Product();
            Console.WriteLine("name : "+Productdeatils.name+" \n price : "+ Productdeatils.price + " \n Quantity: " + Productdeatils.Quantity + " \n Sellprice: " + Productdeatils.Sellprice + " \n" );

            int fixQuantity = Productdeatils.Quantity;
                Console.WriteLine("you want to check Stock deatils \n 1>>yes \n 2>>No");
            int res=int.Parse(Console.ReadLine());
            if (res==1)
            {
                Console.WriteLine("plz enter your order");
                int order = int.Parse(Console.ReadLine());
                QuantityCheck(order, fixQuantity);
            }
          
            


        }
    }
}


