using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.Destructer
{
    class Complex
    {

        int real, img;


        public Complex()
        {
            real = 0;
            img = 0;
        }


        public void SetValue(int r, int i)
        {
            real = r;
            img = i;
        }


        public void DisplayValue()
        {
            Console.WriteLine("Real = " + real);
            Console.WriteLine("Imaginary = " + img);
        }

        ~Complex()
        {
            Console.WriteLine("Destructor was called");
        }
    }
    internal class Desructer
{
       
            static void Main(string[] args)
            {
                Complex C = new Complex();

                C.SetValue(2, 3);

                C.DisplayValue();

            }

         // End class Complex
    }
}
