using System;

namespace Task6_AI
{
    /// <summary>
    /// Represents a financial account with deposit and withdrawal capabilities.
    /// </summary>
    public class Account
    {
        public int AccountNumber { get; set; }
        public string OwnerName { get; set; }
        public double Balance { get; private set; }

        public Account()
        {
            AccountNumber = 10000;
            OwnerName = "Unassigned";
            Balance = 0.00;
        }

        public Account(int number, string owner)
        {
            AccountNumber = number;
            OwnerName = owner;
            Balance = 0.00;
        }

        public Account(int number, string owner, double balance)
        {
            AccountNumber = number;
            OwnerName = owner;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit failed: amount must be positive.");
                return;
            }
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal failed: invalid amount.");
                return;
            }

            if (amount > Balance)
            {
                Console.WriteLine($"[ACCOUNT {AccountNumber}] Insufficient funds: Withdrawal of ${amount:F2} declined.");
                return;
            }

            Balance -= amount;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"[ACCOUNT] => #{AccountNumber} | Owner: {OwnerName} | Balance: ${Balance:F2}");
        }
    }
}
