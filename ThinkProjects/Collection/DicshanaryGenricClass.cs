using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Collection
{
    internal class DicshanaryGenricClass
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> D1 = new Dictionary<int, string>();

            D1.Add(1, "sahadev");
            D1.Add(2, "vijaya");
            foreach (KeyValuePair<int,string> item in D1)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
        }
    }
}
