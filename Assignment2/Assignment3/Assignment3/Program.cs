using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        internal class accounts
        {
            public int accountno;
            public string cname;
            public string accounttype;
            public string transacttype;
            public double amount;
            public double balance = 10000;

            public void display()
            {
                Console.WriteLine("Enter Account Number:");
                this.accountno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Customer's Name:");
                this.cname = Console.ReadLine();
                Console.WriteLine("Enter Account Type:");
                this.accounttype = Console.ReadLine();
                Console.WriteLine("Enter Transaction Type (d->deposit / w->withdrawal):");
                this.transacttype = Console.ReadLine();
                Console.WriteLine("Enter Amount:");
                this.amount = Convert.ToDouble(Console.ReadLine());
                if (transacttype == "d")
                {
                    transacttype = "Deposit";
                    balance = balance + amount;
                }
                else if (transacttype == "w" && amount < balance)
                {
                    transacttype = "Withdrawal";
                    balance = balance - amount;
                }
                else if (transacttype == "w" && amount > balance)
                {
                    transacttype = "" +
                        "Transaction is not possible.";
                }
                Console.WriteLine($"Account Number: { accountno}  Customer's Name: {cname} Account Type: {accounttype} Tansaction Type: { transacttype} Amount: { amount} Remaining Balance: { balance}");
            }
            public static void Main()
            {
                accounts obj = new accounts();
                obj.display();
                Console.ReadLine();
            }
        }
    }
}
