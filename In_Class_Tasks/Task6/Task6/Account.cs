using System;

namespace Task6
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public string OwnerName { get; set; }
        public double Balance { get; private set; }

        // Default constructor
        public Account()
        {
            AccountNumber = 10000;
            OwnerName = "Unknown";
            Balance = 0.0;
        }

        // Constructor with account number and owner name
        public Account( int number, string owner)
        {
            AccountNumber = number;
            OwnerName = owner;
            Balance = 0.0;
        }
        // Constructor with account number, owner name, and initial balance
        public Account(int number, string owner, double balance)
        {
            AccountNumber = number;
            OwnerName = owner;
            Balance = balance;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount<=Balance)
                Balance -= amount;
            else
                Console.WriteLine("Insufficient funds for withdrawal.");

        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Account #{AccountNumber}, Owner: {OwnerName}, Balance: ${Balance:F2}");
        }

    }



}
