/*using DemoProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace DemoProject
{
    class BankAccount
    {
        private string AccountHolderName;
        private string BName = ("Account Name Null...!");
        private string AccountNumber;
        private double AccountBalance;
        public void SetAccountHolderName(string nm)
        {
            AccountHolderName = nm;
        }
        public void SetAccountNumber(string no)
        {
           AccountNumber = no;
        }
        public void SetAccountBalance(double b)
        {
            AccountBalance = b;
        }
        public string GetAccountHolderName()
        {
            if (AccountHolderName!=String.Empty)
            {
                return AccountHolderName; 
            }
            else
            {
                return BName;
            }
        }
        public string GetAccountNumber()
        {
            return AccountNumber;
        }
        public double GetAccountBalance()
        {
            return AccountBalance;        
        }
    }
    class Encapsulation
    {
        public static void Main(String []args)
        {
            BankAccount BA = new BankAccount();
            BA.SetAccountHolderName("");
            BA.SetAccountNumber("072610310000001");
            BA.SetAccountBalance(2585.35);
            Console.WriteLine("Account Name: "+BA.GetAccountHolderName());
            Console.WriteLine("Account Number: " + BA.GetAccountNumber());
            Console.WriteLine("Account Balance: " + BA.GetAccountBalance());
        }
    }
}
