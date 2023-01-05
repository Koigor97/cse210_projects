using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Grammar School Grade Checker\n");

        Console.Write("Please enter your gradepoint: ");
        string grade = Console.ReadLine();
        int gradePoint = int.Parse(grade);
        
        string letter = "";
        string sign = "";

        if (gradePoint >= 90)
        {
            letter = "A";
        }
        else if (gradePoint >= 80 && gradePoint <= 89)
        {
            letter = "B";
        }
        else if (gradePoint >= 70 && gradePoint <= 79)
        {
            letter = "C";
        }
        else if (gradePoint >= 60 && gradePoint <= 69)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (gradePoint >= 90 || gradePoint >= 80 || gradePoint >= 70)
        {
            if (gradePoint % 10 >= 7)
            {
                sign = "+";
            }
            else
            {
                sign = "-";
            }
        }            
            
        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (gradePoint >= 70)
        {
            Console.WriteLine("Congratulations you passed!");
        }
        else
        {
            Console.WriteLine("Don't give up. Better luck next time.");
        }
    }
}