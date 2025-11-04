using System;

namespace Task6_AI
{
    /// <summary>
    /// Represents a car entity with make, model, and year properties.
    /// </summary>
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car()
        {
            Make = "Generic";
            Model = "Sedan";
            Year = DateTime.Now.Year;
        }

        public Car(string make, string model)
        {
            Make = make;
            Model = model;
            Year = DateTime.Now.Year;
        }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        /// <summary>
        /// Displays car details in a formatted console output.
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"[CAR] => {Year} {Make} {Model}");
        }
    }
}
