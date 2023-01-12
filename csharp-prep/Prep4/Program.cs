using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> num = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        bool notQuit = true;

        do
        {
            Console.Write("Enter the numbers: ");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput == 0)
            {
              notQuit = false;
            }
            else
            {
                num.Add(userInput);
            }
        } while (notQuit);
        
        int theSum = num.Sum();
        float theAverage = ((float)theSum) / num.Count;
        int theMaxValue = num.Max();
        int theMinValue = num.Min();

        Console.WriteLine($"The sum is: {theSum}");
        Console.WriteLine($"The average is: {theAverage}");
        Console.WriteLine($"The largest number is: {theMaxValue}");
        Console.WriteLine($"The smallest positive number is: {theMinValue}");
        num.Sort();
        foreach (int number in num)
        {
            Console.WriteLine(number);
        }
    }
}