using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Collection
{
    internal class ListDemo
    {
        class Product
        {
            public int Id { get; set; }
           
            public int Price { get; set; }
            public override string ToString()
            {
                return $"{Id},{Price}";
            }
        }
      
        static void Main(string[] args)
        {
            Product produt1 = new Product { Id = 1, Price = 202 };
             Product produt2 = new Product { Id = 1, Price = 202 };
            List<Product> sl2 = new List<Product>();
            sl2.Add(produt1);
            sl2.Add(produt2);
            foreach (Object item in sl2)
            {
                Console.WriteLine(" Object added in list => "+item);
            }




            int[] a = {6,7,8,9 };
            List<int> sl = new List<int>();

            sl.Add(1);
            sl.Add(2);
            sl.Add(3);
            sl.Add(4);
            sl.Add(5);

            sl.Insert(1,1);

            foreach (var item in sl)
            {
                Console.WriteLine("values add using add method => " + item);
            }
            sl.AddRange(a);
            foreach (var item in sl)
            {
                Console.WriteLine("added one array using addRange => " + item);
            }
            sl.Remove(1);
            foreach (var item in sl)
            {
                Console.WriteLine("after removing 1 Remove => " + item);
            }
            sl.RemoveAt(3);
            foreach (var item in sl)
            {
                Console.WriteLine("after removing index 3 using RemoveAt => " + item);
            }
            
            sl.RemoveRange(2, 2);
            foreach (var item in sl)
            {
                Console.WriteLine("after removing using RemoveRange => " + item);
            }
                sl.Sort();
                foreach (var item in sl)
                {
                    Console.WriteLine("after Sort => " + item);
                }
                sl.Reverse();
                foreach (var item in sl)
                {
                    Console.WriteLine("after Reverse  => " + item);
                   
                }






            }
}
}
