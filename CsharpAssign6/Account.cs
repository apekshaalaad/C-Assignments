using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssign6
{
    public delegate void delegatemethod(int a);
    internal class Account
    {
        public int AccountNumber { get; set; }

        public string CustomerName { get; set; }
        public int Balance = 1000;
        public event delegatemethod underbalance;
        public event delegatemethod zerobalance;
        public void getdetails()
        {
            Console.WriteLine("Enter Account Number: ");
            AccountNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customer Name: ");
            CustomerName = Console.ReadLine();
        }
        public void display()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Account Number is: " + AccountNumber);
            Console.WriteLine("Customer name is: " + CustomerName);
        }
        public void getempdetails()
        {
            getdetails();
            display();

        }
        public void insufficient(int a)
        {
            underbalance(a);
        }
        public void depositmoney(int b)
        {
            zerobalance(b);
        }
        public void withdraw(int a)
        {
            if (a < Balance && Balance != 0)
            {
                Console.WriteLine("Transaction Successfull");
                Console.WriteLine("Remaining Balance is " + (Balance - a));
            }
            else if (a > Balance && Balance != 0)
            {
                Console.WriteLine("Insufficient Amount");
                Console.WriteLine("Your Current Balance is " + Balance + "only");
            }
            else
            {
                Console.WriteLine("Zero Balance :" + Balance);
            }
        }
        public void Deposit(int a)
        {
            Console.Write("Balance After Depositing: " + (Balance + a));
        }
        static void Main(string[] args)
        {
            Account obj = new Account();
            obj.getempdetails();
            Console.WriteLine("Withdraw Amount or Deposit : W or D");
            string W = Console.ReadLine();
            if (W == "W")
            {
                Console.WriteLine("Enter Amount to Withdraw: ");
                int Wbalance = Convert.ToInt32(Console.ReadLine());
                obj.underbalance += new delegatemethod(obj.withdraw);
                obj.insufficient(Wbalance);
            }
            else
            {
                Console.WriteLine("Enter Amount to Deposit: ");
                int Dbalance = Convert.ToInt32(Console.ReadLine());
                obj.zerobalance += new delegatemethod(obj.Deposit);
                obj.depositmoney(Dbalance);
            }
            Console.Write("\nPress any key to close ");
            Console.ReadKey();
        }
    }
}
