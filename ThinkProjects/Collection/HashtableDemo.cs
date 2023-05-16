using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Collection
{
    internal class HashtableDemo
    {
        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable();
            hash.Add(7559181217, "sahadev");
            hash.Add(9356166820, "vijaya");
            foreach ( DictionaryEntry item in hash)
            {
                Console.WriteLine($"Hash key is {item.Key} hash Vaule is {item.Value}");

            }
            hash.Remove(9356166820);
            Console.WriteLine("after removing element");
           
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine($"Hash key is {item.Key} hash Vaule is {item.Value}");

            }
        }
    }
}
