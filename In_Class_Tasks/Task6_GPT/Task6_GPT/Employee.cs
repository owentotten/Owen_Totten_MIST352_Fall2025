using System;

namespace Task6_AI
{
    /// <summary>
    /// Represents an employee with name, hourly pay rate, and weekly hours.
    /// </summary>
    public class Employee
    {
        public string Name { get; set; }
        public double HourlyRate { get; set; }
        public int HoursPerWeek { get; set; }

        public Employee()
        {
            Name = "New Hire";
            HourlyRate = 15.00;
            HoursPerWeek = 30;
        }

        public Employee(string name)
        {
            Name = name;
            HourlyRate = 15.00;
            HoursPerWeek = 30;
        }

        public Employee(string name, double rate, int hours)
        {
            Name = name;
            HourlyRate = rate;
            HoursPerWeek = hours;
        }

        public double CalculateAnnualSalary()
        {
            return HourlyRate * HoursPerWeek * 52;
        }

        public void DisplaySummary()
        {
            Console.WriteLine($"[EMPLOYEE] => {Name} | ${HourlyRate:F2}/hr | {HoursPerWeek} hrs/week | Annual: ${CalculateAnnualSalary():F2}");
        }
    }
}
