using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.OOPs
{
    /*wap to show Contenment for Order.order has order id Quantity
  and menu.manu has menu id, menu item , price*/

   public class Order
    {
        int orderid;
        int orderquantity;
        Menu menu;
        public Order(int orderid,int orderquantity, Menu menu)
        {
            this.orderid = orderid;
            this.orderquantity = orderquantity;
           this.menu = menu;    
        }  
        public void showOrder() {
            Console.WriteLine("OrderId is : "+orderid+"\nOrderquantity is : "+orderquantity);
            menu.display();
          
        }

    }
   public class Menu
    {
        int menuid;
        string menuitem;
        int menuprice;
      

        public Menu(int menuid,string menuitem,int menuprice)
        {
            this.menuid = menuid;
            this.menuitem = menuitem;
            this.menuprice = menuprice;
           
        }
        public void display()
        {
            Console.WriteLine("MenuId is : "+menuid+"\nMenuItem is : "+menuitem+"\nMenuprice is : "+menuprice);
        }
        static void Main(string[] args)
        {
            Menu m = new Menu(1, "tata", 12000);
            Order order = new Order(1,3,m);
            order.showOrder();
        }
    }
}
