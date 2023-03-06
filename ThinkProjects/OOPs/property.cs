using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.OOPs
{
    internal class property
    {
        int id;
        string name;
        string location;
        double rating;
         bool isOnlineOrderAvaleible;
         string seatingCapacity ;
        string paymentType;
         int Id { get; set; }
         string Name { get; set; }
         string Location { get; set; }
         double Rating { get; set; }
         bool IsOnlineOrderAvaleible { get; set; }
         string SeatingCapacity { get; set; }
         string PaymentType { get; set; }
      
       
        static void Main(string[] args)
        {
            property p1=new property();
            p1.Id = 1;
            p1.Name = "test";
            p1.SeatingCapacity = "400";
            p1.IsOnlineOrderAvaleible = true;
            p1.Location = "sangola";
            p1.PaymentType = "Payment";
            p1.Rating= 4.5;

            Console.WriteLine("User Id : "+p1.Id+"\nUser Name : "+p1.Name+"\nUser Location : "+p1.Location+"\nHotelSeating Capcity is : "+p1.SeatingCapacity+"\nOnlineOrder : "+p1.IsOnlineOrderAvaleible+"\nPaymentType i : "+p1.PaymentType+" You give me the rate : "+p1.Rating);
        }
    }
}
