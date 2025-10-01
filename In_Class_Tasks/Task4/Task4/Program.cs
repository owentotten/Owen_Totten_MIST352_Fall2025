namespace Task4
    //Owen Totten
    //10/1/2025
{
    internal class Program
    {
        //Main method
        //Entry point of the program
        static void Main(string[] args)
        {
            int[] numbers = { 11, 32, 3, 84, 5, 76 };
            //calling the method to print array numbers
            PrintArray(numbers);
            //calling the method to find average of array numbers
            Console.WriteLine("Average: " + FindAverage(numbers));
            //calling the method to search for a specific number in the array
            DisplaySearchResult();
            //calling the method to find the largest number in the array
            FindLargest(numbers);
        }



        //Method to print array elements
        static void PrintArray(int[] numbers)
        {
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
        //Method to find the average of array elements
        static double FindAverage(int[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum / numbers.Length;
            Console.WriteLine("Average: " + FindAverage(numbers));
        }

        //Method to search for a specific number in the array
        //Prints wether or not the number was found in the array
        static void DisplaySearchResult()
        {
            Console.WriteLine("Enter a number to search:");
            string strsearchnumber = Console.ReadLine();
            Console.WriteLine($"{strsearchnumber} was found in the array!");
        }
        //Method to find the largest number in the array and print it
        static void FindLargest(int[] numbers)
        {
            int largest = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }
            Console.WriteLine("Largest number: " + largest);
        }


    }
}
  


