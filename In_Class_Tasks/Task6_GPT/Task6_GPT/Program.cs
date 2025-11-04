using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Principal;

namespace Task6_AI
{
    //I prompted chat gpt to write write a better version of code for an assignment i gave it a screengrab of the posted assignment instructions on ecampus and gave it a copy of my code from task 6.
    //The ai generated different documentation and more decriptive naming
    internal class Program
    {
        /// <summary>
        /// Application entry point.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("========== VEHICLE RECORDS ==========");
            Car carAlpha = new Car();
            Car carBeta = new Car("Toyota", "Camry");
            Car carGamma = new Car("Honda", "Civic", 2020);
            carAlpha.DisplayInfo();
            carBeta.DisplayInfo();
            carGamma.DisplayInfo();

            Console.WriteLine(Environment.NewLine + "========== EMPLOYEE DIRECTORY ==========");
            Employee employeeA = new Employee();
            Employee employeeB = new Employee("Alice");
            Employee employeeC = new Employee("Bob", 24.75, 40);
            employeeA.DisplaySummary();
            employeeB.DisplaySummary();
            employeeC.DisplaySummary();

            Console.WriteLine(Environment.NewLine + "========== ACCOUNT REGISTER ==========");
            Account accountOne = new Account();
            Account accountTwo = new Account(123, "Sam Smith");
            Account accountThree = new Account(456, "Jane Doe", 1500.00);

            accountTwo.Deposit(500.00);
            accountTwo.Withdraw(200.00);
            accountThree.Withdraw(7000.00); // Expected insufficient funds warning

            accountOne.DisplayInfo();
            accountTwo.DisplayInfo();
            accountThree.DisplayInfo();

            Console.WriteLine(Environment.NewLine + "Process Completed Successfully.");
        }
    }
}
