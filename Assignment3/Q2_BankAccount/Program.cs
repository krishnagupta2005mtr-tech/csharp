using System;

namespace Q2_BankAccount
{
    class BankAccount
    {
        private string accountNumber;
        private string holderName;
        private double balance;

        public BankAccount(string accountNumber, string holderName, double balance)
        {
            this.accountNumber = accountNumber;
            this.holderName = holderName;
            this.balance = balance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("Amount deposited: " + amount);
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Amount withdrawn: " + amount);
            }
            else
            {
                Console.WriteLine("Insufficient balance or invalid amount.");
            }
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("\n--- Account Details ---");
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Holder Name: " + holderName);
            Console.WriteLine("Balance: " + balance);
        }

        static void Main(string[] args)
        {
            BankAccount account =
                new BankAccount("123456789", "Krishna", 10000);

            account.Deposit(5000);
            account.Withdraw(2000);
            account.DisplayAccountDetails();

            Console.ReadKey();
        }
    }
}