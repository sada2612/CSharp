using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.DiligateAndEvents
{
  public  delegate void DiligateHandler();
    internal class DiligateDemo
{
        public static void User()
        {
            Console.WriteLine("Hii User");
        }
        public static void UserData()
        {
            Console.WriteLine("Hii User its userdata mets");
        }
        static void Main(string[] args)
        {

            DiligateHandler d1 = new DiligateHandler(DiligateDemo.User);
            d1.Invoke();
            d1 = UserData;
            d1();
    }


}
}
