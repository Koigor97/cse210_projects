using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!\n");
        Assignment assignment = new Assignment("Samuel Turay", "Programming");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine("");

        MathAssignment mathAssignment = new MathAssignment("Sarah Alpha", "Fraction", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine("");

        WritingAssignment writingAssignment = new WritingAssignment("Koirah", "Africa History", "The Period of West Africa Independence");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
        
    }
}