using System;

namespace Task6
{
    public class Employee
    {
        public string Name { get; set; }
        public double HourlyRate { get; set; }
        public int HoursPerWeek { get; set; }
        // Default constructor
        public Employee()
        {
            Name = "New Hire";
            HourlyRate = 15.00;
            HoursPerWeek = 30;
        }
        // Constructor with name
        public Employee(string name)
        {
            Name = "name";
            HourlyRate = 15.00;
            HoursPerWeek = 30;
        }
        // Constructor with name, hourly rate, and hours per week
        public Employee(string name, double rate, int hours)
        {
            Name = name;
            HourlyRate = rate;
            HoursPerWeek = hours;
        }
        public double AnnualSalary()
        {
            return HourlyRate * HoursPerWeek * 52;
        }
        public void DisplaySummary()
        {
            Console.WriteLine($"Employee: {Name}, Hourly Rate: ${HourlyRate:F2}, Hours/Week: {HoursPerWeek}, Annual Salary: ${AnnualSalary():F2}");
        }
    }
}
