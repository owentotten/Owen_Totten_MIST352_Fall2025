using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Task7
{
    public class Account
    {
        private int _id;
        private string _accountType;
        public DateOnly OpenDate;
        private decimal _balance;
        private decimal depositAmount;
        private string _CustomerCustomer;

        public int ID
        {
            get { return _id; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Account ID must be positive. Account ID remains {_id}. Try again");
                }
                else
                {
                    _id = value;
                }
            }
        }

        public string AccountType
        { get { return _accountType; } }


        public decimal Balance
        {
            get { return _balance; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine($"Balance can not be negative. Account balance remains {_balance}. Try again");
                }
                else
                {
                    _balance = value;
                }
            }
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive. Try again.");
            }
            else
            {
                _balance += amount;
                Console.WriteLine($"Successfully deposited {amount:C}. New balance is {_balance:C}.");
            }
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive. Try again.");
            }
            else if (amount > _balance)
            {
                Console.WriteLine("Insufficient funds for this withdrawal. Try again.");
            }
            else
            {
                _balance -= amount;
                Console.WriteLine($"Successfully withdrew {amount:C}. New balance is {_balance:C}.");
            }
        }

        public string CustomerCustomer
        //Links account to customer
        {
            get { return _CustomerCustomer; }
            set
            {
                if (value is null || value.Equals(""))
                {
                    Console.WriteLine($"Customer can not be null or empty. Account customer remains {_CustomerCustomer}. Try again");
                }
                else
                    _CustomerCustomer = value;
            }
        }
            public string AssignCustomer(string customerName)
           //prevents orphaned accounts
            {
                if (customerName is null || customerName.Equals(""))
                {
                    return "Customer name cannot be null or empty. Try again.";
                }
                else
                {
                    _CustomerCustomer = customerName;
                    return $"Customer {_CustomerCustomer} assigned to account {_id}.";
                }
        }

        public decimal CloseAccount()
      //Allowed only if balance is zero
        {
            if (_balance != 0)
            {
                Console.WriteLine("Account cannot be closed unless the balance is zero. Please withdraw remaining funds before closing the account.");
                return _balance;
            }
            else
            {
                Console.WriteLine($"Account {_id} closed successfully.");
                return 0;
            }
        }



        public void DisplayInfo()
        {
            Console.WriteLine($"Account ID: {_id}\tType: {_accountType}\tOpen Date: {OpenDate}\tBalance: {_balance:C}\tCustomer: {_CustomerCustomer}");
        }
    }
}




