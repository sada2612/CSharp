using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Test4
{
    internal class DuckNo
{
        public static bool Duck(string no)
        {
            int length = no.Length; int i = 0;
            while ( i< length && no[i]=='0') {
                i++;
            }
            while (i < length )
            {if (no[i] == '0') 
                    return true;
                    i++;
                
              
            }
            return false;
        }
        static void Main(string[] args)
        {
            string num = "0120340";
           bool result= DuckNo.Duck(num);
            if (result)
            {
                Console.WriteLine(  "no is duck");
            }
            else
            {
                Console.WriteLine("no is not duck");
            }

        }
}
}
