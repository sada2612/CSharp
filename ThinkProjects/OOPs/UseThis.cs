using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.OOPs
{
    public class UseThis
    { 
        
        string name1;
        public UseThis(){
            Console.WriteLine("hii defualt contructer");
            
        }
        public UseThis(string name) {
            Console.WriteLine("hii "+name+" its parametred contructer");
            
        }
       public void testc() { Console.WriteLine("hii "+this.name1+"it's methods getting value using this keyword referance"); }

        static void Main(string[] args)
        {
            UseThis a1= new UseThis(); 
            a1.name1= "sahadev";
            a1.testc();
            UseThis a2=new UseThis("viju");
        }
    }
}
