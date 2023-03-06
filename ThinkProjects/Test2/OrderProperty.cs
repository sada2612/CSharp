using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Test2
{
    class Order
    {

        int order_id;
        string city;
        string cust_name;
        bool isDelivered;
          public  int Order_Id { get; set; }
        public string Cust_Name { get; set; }
        public string City { get; set; }

        public bool Isdeliverd { get; set; }
        
    }
    internal class OrderProperty
    {//7.	Write Property for the class Order contain  (order_id,city,cust_name,isDelivered).
        static void Main(string[] args)
        {
            Order o1= new Order();
               o1.Order_Id = 1;
            o1.Cust_Name = "sahadev";
            o1.City = "sangola";
            o1.Isdeliverd = true;
        }
    }
}
