using System;

namespace Task6
{//Task 6
//Owen Totten
//11/4/25
//make 3 cars, 3 employees, 3 accounts
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("===Cars===");
            var carA = new Car();
            var carB = new Car("Toyota", "Camry");
            var carC = new Car("Honda", "Civic", 2020);
            carA.DisplayInfo();
            carB.DisplayInfo();
            carC.DisplayInfo();

            //Employees
            Console.WriteLine("===Employees===");
            var e1 = new Employee();
            var e2 = new Employee("Alice");
            var e3 = new Employee("Bob", 24.75, 40);
            e1.DisplaySummary();
            e2.DisplaySummary();
            e3.DisplaySummary();

            //Accounts
            Console.WriteLine("\n===Accounts===");
            var a1= new Account();
            var a2 = new Account(123, "Sam Smith");
            var a3 = new Account(456, "Jane Doe", 1500.00);
            a2.Deposit(500.00);
            a2.Withdraw(200.00);
            a3.Withdraw(7000);//should show insufficient funds
            a1.DisplayInfo();
            a2.DisplayInfo();
            a3.DisplayInfo();
            Console.WriteLine("\nDone!");

        }
    }
}
