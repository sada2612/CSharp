﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Loopassignment
{//1.	WAP to print even numbers from 121 to 229 using do-while loop. 
    internal class EvanDoWhile
    {
        static void Main(string[] args)
        { int i = 121;
            do
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
                i++;
            } while (i<=229);
        }
    }
}
