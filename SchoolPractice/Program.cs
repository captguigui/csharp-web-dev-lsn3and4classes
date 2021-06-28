using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student guigui = new Student();

            guigui.Name = "Guillermo";
            guigui.NumberOfCredits = 1;
            guigui.Gpa = 4.0;

            Console.WriteLine($"The student {guigui.Name} has a GPA of {guigui.Gpa} with {guigui.NumberOfCredits} credit(s).");

        }
    }
}
