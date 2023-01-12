using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        static void WelcomeMsg ()
        {
            Console.WriteLine("Welcome to C# Programming!");
        }

        WelcomeMsg();

        Console.Write("What is your name: ");
        string name = Console.ReadLine();

        Console.Write("Please enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());

        static int SquareNumber (int theNum)
        {   
            theNum *= theNum;
            return theNum;
        }

        Console.WriteLine($"Hello {name}, the square root of {num} is {SquareNumber(num)}. Cool right! 😎");
    }
}