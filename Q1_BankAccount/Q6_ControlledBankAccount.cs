using System;

namespace Q6_ControlledBankAccount
{
    class BankAccount
    {
        public string AccountNumber { get; set; }

        public string AccountHolder { get; set; }

        public double Balance { get; private set; }

        public BankAccount(string accountNumber,
                           string accountHolder,
                           double initialBalance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;

            if (initialBalance >= 0)
            {
                Balance = initialBalance;
            }
            else
            {
                Balance = 0;
            }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance = Balance + amount;
                Console.WriteLine("Deposit successful.");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance.");
            }
            else
            {
                Balance = Balance - amount;
                Console.WriteLine("Withdrawal successful.");
            }
        }

        public void DisplayAccount()
        {
            Console.WriteLine("\nAccount Number: " + AccountNumber);
            Console.WriteLine("Account Holder: " + AccountHolder);
            Console.WriteLine("Updated Balance: " + Balance);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account =
                new BankAccount("ACC1001", "Krishna", 10000);

            account.Deposit(5000);

            account.Withdraw(3000);

            account.DisplayAccount();

            Console.ReadKey();
        }
    }
}