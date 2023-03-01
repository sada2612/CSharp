using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Loopassignment
{
    internal class ForBreak
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)

                if (i == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(i);
                }
        }
            
        }
    }


