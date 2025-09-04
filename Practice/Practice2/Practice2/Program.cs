/*
 * Owen Totten
 * *Tuesday 9/2/25
 * Practice with user imputs
 */


using static System.Net.Mime.MediaTypeNames;

namespace Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dblVal1, dblVal2;
            Console.WriteLine("Give me the first value: ");
            dblVal1 = Convert.ToDouble(Console.ReadLine());
            //Test
            //Console.WriteLine(dblVal1);

            Console.WriteLine("Give me the second value: ");
            dblVal2 = Convert.ToDouble(Console.ReadLine());
            // Test
            double dblTotal = dblVal1 + dblVal2;
            Console.WriteLine($"The sum of {dblVal1} and {dblVal2} is {dblVal2}");

            
            int dblVal1, dblVal2;
            Console.WriteLine("Give me the first value: ");
            dblVal1 = Convert.ToDouble(Console.ReadLine());
            //Test
            //Console.WriteLine(dblVal1);

            Console.WriteLine("Give me the second value: ");
            dblVal2 = Convert.ToDouble(Console.ReadLine());
            // Test
            double dblTotal = dblVal1 + dblVal2;
            Console.WriteLine($"The sum of {dblVal1} and {dblVal2} is {dblVal2}");

        }

    }
}
