using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.OOPs.Inheristance
{
   public class Eat
    {
      public string property = "Every man is eating";
    }
    class NonVeg : Eat
    {
        string NonV = "it's meat";

        public NonVeg() {
            Console.WriteLine(base.property + "Vegiterian is eats" + NonV);
        } 
    }
    class Veg : Eat
    {
        string V = "it's Vegitables and veg foods";
        public Veg() {
            Console.WriteLine(base.property+"Vegiterian is eats"+V);
        }
    }
    internal class Hierarchical2
    {
        static void Main(string[] args)
        {
            NonVeg n1=new NonVeg();
            Veg n2=new Veg();

        }
    }
}
