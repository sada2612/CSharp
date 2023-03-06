
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace ThinkProjects.OOPs

{
    
    public class HotelWithAllProperty
{  //class hotel,int id,string name,string location,double rating,bool isonlineorderisAvaleible,string seatingcapicity
    //string paymenttype
    int id;
    string name;
    string location;
    double rating;
   public bool isOnlineOrderAvaleible;
   public static string seatingCapacity = "20";
    string paymentType;
       
   
    public HotelWithAllProperty(int id, string name, string location)
    {
        this.id = id;
        this.name = name;
        this.location = location;
        
    }
      
        public void OnlineOredermsg(int res)
        {

            int Time = DateTime.Now.Hour;

            if (Time >= 8 && Time <= 24)
            {
                isOnlineOrderAvaleible = true;
               

            }
            else
            {
                isOnlineOrderAvaleible = false;
               

            }
            if (isOnlineOrderAvaleible == true && res==1)
            {
                Console.WriteLine("online Order are Accepted in current time");
               
               
            }
            else if(isOnlineOrderAvaleible == false && res == 1) 
            {
                Console.WriteLine("Current time OnlineOrder is not accpect try after 8 PM ");
            }
        }

    void Display()
    {
        Console.WriteLine();
    }
    public void onlineorder( int res)
    {
      

       if (isOnlineOrderAvaleible==true)
            {
               
                if (res==1)
                {
                    Console.WriteLine("please Enter your order");
                    Console.WriteLine("1 >> Full Thali : 250 $ \n2 >> Half Thali : 150 $");
                    int Order=int.Parse(Console.ReadLine());
                    Console.WriteLine("Please Select The PaymentType Enter The Number");
                    Console.WriteLine("1 -> Google Pay \n2 -> Phone pay\n3 -> Bharat pay\n4 -> Net Banking\n5 -> Cash On Delivery");
                    int pres = int.Parse(Console.ReadLine());
                   
                    if (Order==1)
                    {
                        Console.WriteLine("your bill is 250 ");
                        string ptype = "";
                        switch (pres)
                        {
                            case 1:
                                ptype = " Google Pay";
                                break;
                            case 2:
                                ptype = " Phone pay";
                                break;
                            case 3:
                                ptype = "Bharat pay";
                                break;
                            case 4:
                                ptype = "Net Banking";
                                break;
                            case 5:
                                ptype = "Cash On Delivery";
                                break;



                        }
                        if (ptype == " Google Pay" || ptype == "Bharat pay" || ptype == "Net Banking" || ptype == " Phone pay")
                        {
                            Console.WriteLine("please enter the " + ptype + " Code");
                            string paycode = Console.ReadLine();
                            Console.WriteLine("Payment Sucessfull !");
                            Console.WriteLine("order is Comming soon");
                        }
                        else
                        {

                            Console.WriteLine("it's ok you select " + ptype);
                            Console.WriteLine("order is Comming soon");
                        }
                       
                    }
                    else
                    {
                        Console.WriteLine("your bill is 150 ");
                        string ptype = "";
                        switch (pres)
                        {
                            case 1:
                                ptype = " Google Pay";
                                break;
                            case 2:
                                ptype = " Phone pay";
                                break;
                            case 3:
                                ptype = "Bharat pay";
                                break;
                            case 4:
                                ptype = "Net Banking";
                                break;
                            case 5:
                                ptype = "Cash On Delivery";
                                break;



                        }
                        if (ptype==" Google Pay"||ptype=="Bharat pay"|| ptype=="Net Banking"|| ptype==" Phone pay")
                        {
                            Console.WriteLine("please enter the " + ptype + " Code");
                            string paycode = Console.ReadLine();
                            Console.WriteLine("Payment Sucessfull !");
                            Console.WriteLine("order is Comming soon");
                        }
                        else
                        {
                            Console.WriteLine("it's ok you select "+ptype);
                            Console.WriteLine("order is Comming soon");
                        }
                    }
                   
                }
               

        }
       

    }
       
    static void Main(string[] args)
        {
            Console.WriteLine("Thanks For visit our site Please the survey");
           
            Console.WriteLine("Please Enter Your Id ");
            int Id = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Please Enter Your Name");
            string Name=Console.ReadLine();
           
            Console.WriteLine("Please Enter Your Location");
           string Location = Console.ReadLine();

          

            HotelWithAllProperty h1=new HotelWithAllProperty(Id, Name, Location);
            Console.WriteLine("you want to Online Order \n 1> yes \n 2> no");
            int onlineOres = int.Parse(Console.ReadLine());
            h1.OnlineOredermsg(onlineOres);
            if (h1.isOnlineOrderAvaleible==true)
            {
                h1.onlineorder(onlineOres);
            }
            else
            {

                Console.WriteLine(" it's ok");
                Console.WriteLine("How Much  seats are you going to book  today? please Enter");
                int Bookseats = int.Parse(Console.ReadLine());
                int finalseats = int.Parse(seatingCapacity);
                if (Bookseats > finalseats)
                {
                    Console.WriteLine("sorry emterd seat is not avelabel \n" + (finalseats - Bookseats) + " seats are remaining");
                }
                else
                {
                    Console.WriteLine("ok Done Your seats is booked today");
                    Console.WriteLine("please Give the rateing our side");
                    float Rateing = float.Parse(Console.ReadLine());
                    Console.WriteLine("Thanks visiting our site and giveing " + Rateing + " stars Our servies");
                }

            }








            //  User1.Display();
        }
    }
}