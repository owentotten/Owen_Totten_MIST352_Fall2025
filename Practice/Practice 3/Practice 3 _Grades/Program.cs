namespace Practice_3__Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Owen Totten
            //Practice 3 - Grades
            double dblGrade1, dblGrade2, dblGrade3, dblGPA;

            Console.WriteLine("What is your name?");

            string strName;

            Console.Write("Provide grade1");
            dblGrade1 = Convert.ToDouble(Console.ReadLine());  

            
            Console.Write("Provide grade2");
            dblGrade2 = Convert.ToDouble(Console.ReadLine()); 

            
            Console.Write("Provide grade3");
            dblGrade3 = Convert.ToDouble(Console.ReadLine());   

            strName = Console.ReadLine();

            dblGPA = (dblGrade1 + dblGrade2 + dblGrade3) / 3;
            Console.WriteLine($"Hello {strName}, the GPA of your grades {dblGrade1}, {dblGrade2}, {dblGrade3} is {dblGPA}");

            bool blnFail;
            blnFail = dblGPA <=50;
            Console.Write($"Failed? {blnFail}");
        }
    }
}
