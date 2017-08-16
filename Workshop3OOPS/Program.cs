using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3OOPS
{
    class Account
    {
        string accountNumber, accountHolderName;
        double accountBalance;

        public Account(string accNum, string accHoldName, double accBal)
        {
            accountNumber = accNum;
            accountHolderName = accHoldName;
            accountBalance = accBal;
        }

        public void Deposit(double deposit)
        {
            accountBalance = accountBalance + deposit;
            Console.WriteLine("Deposit was successful!");
        }

        public void Withdraw(double withdrawal)
        {
            if (withdrawal > accountBalance)
            {
                Console.WriteLine("Withdrawal amount exceeds account balance!");
            }
            else
            {
                accountBalance = accountBalance - withdrawal;
                Console.WriteLine("Withdrawal was successful!");
            }
        }
        public void TransferTo(double amount, Account otherAccount)
        {
            this.accountBalance = this.accountBalance - amount;
            otherAccount.accountBalance = otherAccount.accountBalance + amount;
            Console.WriteLine("Transfer was successful!");
        }
        public string Show()
        {
            string s = String.Format("[Account: {0}, {1}, {2}]", accountNumber, accountHolderName, accountBalance);
            return s;
        }
    }
    class BankTest
    {
        static void Main(string[] args)
        {
            Account a = new Account("001-001-001", "Tan Ah Kow", 2000);
            Account b = new Account("001-001-002", "Kim Keng Lee", 5000);
            Console.WriteLine(a.Show());
            Console.WriteLine(b.Show());
            a.Deposit(100);
            Console.WriteLine(a.Show());
            a.Withdraw(200);
            Console.WriteLine(a.Show());
            a.TransferTo(300, b);
            Console.WriteLine(a.Show());
            Console.WriteLine(b.Show());
            Console.ReadKey();
        }
    }
}