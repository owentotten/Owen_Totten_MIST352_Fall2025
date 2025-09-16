using System.Xml.Schema;

namespace Practice5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String strName = "MJ Ahmad";
            double dblGrade1 = 90.5, dblGrade2 = 85.0, dblGrade3 = 88.5, dblGrade4 = 92.0, dblGrade5 = 67.0, dblAvg = 0;
            dblAvg = (dblGrade1 + dblGrade2 + dblGrade3 + dblGrade4 + dblGrade5) / 5;
            Console.WriteLine($"Student Name: {strName}, Your Average Grade is: {dblAvg}");


            //Arrays
            //Allow you to store multiple data types in a single variable
            //define an array of double to store grades
            //The second set of brackets is how  any variables you want to store in the array
            double[] dblGrades = new double[5];
            dblGrades[0] = 90.5;
            dblGrades[1] = 85.0;
            dblGrades[2] = 88.5;
            dblGrades[3] = 92.0;
            dblGrades[4] = 67.0;

            String[] strAssessments = { "Task 1", "HW1", "Quiz 1", "Exam 1" };




            double[] dblGradesFancy = { 90.5, 85.0, 88.5, 92.0, 67.0, 99.9 };
            Console.WriteLine($"{dblGradesFancy[0]} - {dblGradesFancy[1]} - {dblGradesFancy[2]} - {dblGradesFancy[3]} - {dblGradesFancy[4]}");
            //Calculate the average (manual way)
            dblAvg = (dblGrades[0] + dblGrades[1] + dblGrades[2] + dblGrades[3] + dblGrades[4]) / 5;
            Console.WriteLine($"Student Name: {strName}, Your Average Grade is: {dblAvg}");


            //for loop to interact with arrays
            for (int intIndex = 0; intIndex < dblGradesFancy.Length; intIndex++)
            {

                Console.WriteLine(dblGradesFancy[intIndex]);
            }

        }




        //define an array of grades and assessments
        string[] strAssessments = { "Task 1", "HW1", "Task 2", "Exam 1", "HW2" };
        float[] fltGrades = { 90, 85, 88, 92, 67, 99 };

        //for loop to access/ read/ manipulate the array
        for (int intIndex = 0; intIndex < strAssesments.Length; intIndex++)
        {
           Console.WriteLine($ "Assesment strAssessments[intIndex]);
        }



}
