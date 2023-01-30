using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Encapsulation
{
    public class Invoice
    {

        int account;
        string customer;
        string provider;
        

        public Invoice(int account, string customer, string provider)
        {

            this.account = account;
            this.customer = customer;   
            this.provider = provider;   


        }

        private string articl;
        
        public string Article
        {
            get
            {
                return articl;
            }
            set
            {
                articl = value;

            }
        }

            private int quantity;

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        private decimal price;
        public decimal Price { get
            { 
                return price;
            }
            set 
            { 
                price = value;  
            } }
        public void CostCalculation(bool needEdv)
        {

            if (needEdv == true)
            {
                Console.WriteLine(Price * Quantity *(decimal) 0.18); 

            }
            else
            {
                Console.WriteLine(Price * Quantity); 
            }

            





        }
    }
}
