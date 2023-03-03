using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProjects.OOPs
{
   
        internal class AccountDetails
        {
        public class Account
        {
            string name;
            Int32 accountNo;
            string address;
            Int32 postalCode;

            public string Name
            {
                set
                {
                    name = value;
                }
                get
                {
                    return name;
                }
            }
            public string Address
            {
                set
                {
                    address = value;
                }
                get
                {
                    return address;
                }
            }
            public Int32 PostalCode
            {
                set
                {
                    postalCode = value;
                }
                get
                {
                    return postalCode;
                }
            }
            public Int32 AccountNo
            {
                set
                {
                    accountNo = value;
                }
                get
                {
                    return accountNo;
                }
            }
        }


        static void Main(string[] args)
            {
           
            Account a1 = new Account();
            a1.AccountNo = 12345;
            a1.Address = "Shivangi";
            a1.Name = "Sahadev padavale";
            a1.PostalCode = 413319;
            Console.WriteLine("AccountNo :"+a1.AccountNo+"\n address :" + a1.Address+"\n Name :" + a1.Name+"\n PostalCode :" + a1.PostalCode);
           
            }
        }
    }
