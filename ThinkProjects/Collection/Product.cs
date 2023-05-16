using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Collection
{
   
        class Product
        {


            public int Id { get; set; }
            public string  PName { get; set; }
            public int Price { get; set; }
            public override string ToString()
            {
                return $"{Id},{PName},{Price}";
            }

            static void Main(string[] args)
            {
                Product p1 = new Product { Id = 1, PName = "sahadev", Price = 233 };

                ArrayList list = new ArrayList();
                list.Add(p1);
                list.Add(new Product { Id = 2, PName = "sahadev2", Price = 2333 });

            ArrayList list2 = new ArrayList {
            new Product { Id = 3, PName = "sahadev3", Price = 23334 },
             new Product { Id = 4, PName = "sahadev4", Price = 233345 }
            };
            foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            foreach (var item in list2)
            {
                Console.WriteLine(item);

            }

            }
        }
    }

