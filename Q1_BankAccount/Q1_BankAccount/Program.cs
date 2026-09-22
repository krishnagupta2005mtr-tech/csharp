using System;

namespace Q1_BankAccount
{
    class BankAccount
    {
        public string AccountNumber { get; set; }

        private double balance;

        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value >= 0)
                    balance = value;
                else
                    Console.WriteLine("Balance cannot be negative.");
            }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance = Balance + amount;
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            account.AccountNumber = "ACC101";
            account.Balance = 5000;

            account.Deposit(2000);

            Console.WriteLine("Account Number: " + account.AccountNumber);
            Console.WriteLine("Final Balance: " + account.Balance);

            Console.ReadKey();
        }
    }
}