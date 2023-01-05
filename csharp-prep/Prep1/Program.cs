using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello Sir, can I get your first name please? ");
        string firstName = Console.ReadLine();

        Console.Write("And your last name sir? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
    }
}