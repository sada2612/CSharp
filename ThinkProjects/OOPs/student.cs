using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThinkProjects.Loopassignment;

namespace ThinkProjects.OOPs
{//craete student class student has id,name and 5 subject marks create 1st method to assign data
 //2nd calculate per 3rd method assign greade 4th diplay stu data with result
    internal class student
    {
      public  int stuId;
      public  string name;
        public  int sub1;
        public int sub2;
        public int sub3;
        public int sub4;
        public int sub5;
        public int sturesult;


      public  char studgreade;
        public student(int stuId, string name, int sub1, int sub2,int sub3,int sub4,int sub5) {

            this.stuId= stuId;
            this.name= name;
            this.sub5 = sub5;
            this.sub1 = sub1;
            this.sub3 = sub3;   
            this.sub4 = sub4;
            this.sub2= sub2;


        }

        public void per()
        {
            int sum = sub1 + sub2 + sub3 + sub4 + sub5;
          sturesult = (int)(0.5f + ((100f * sum) / 500));
           
           
           
        }
        public void greade()
        {
            if (sturesult<=35)
            {
                studgreade = 'f';
            }else if (sturesult>35&&sturesult<50)
            {
                studgreade = 'c';
            }
            else if (sturesult > 50 && sturesult < 70)
            {
                studgreade = 'b';
            }
            else if (sturesult > 70 && sturesult < 80)
            {
                studgreade = 'a';
            }
            else
            {
                studgreade = 's';
            }
        }
        public void display()
        {
            Console.WriteLine(" it's student details");
            Console.WriteLine("Stdent is is :"+stuId+"\nStudent Name is :"+ name+"\n student pertange is :"+sturesult+"\n student Greade is :"+studgreade);
        }
   
        static void Main(string[] args)
        {
            student s1 = new student(1,"sahadev",65,66,67,68,69);
            s1.per();
            s1.greade();
            s1.display();
        }
    }
}
