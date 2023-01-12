using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random numberGenerator = new Random();
        int magicNum = numberGenerator.Next(1, 100);

        bool isCorrect = true;
        int numOfGuesses = 0;

        do
        {
          Console.Write("Guess the magic number: ");
          int guess = int.Parse(Console.ReadLine());
          numOfGuesses++;

          if (magicNum == guess)
          {
            isCorrect = false;
            Console.WriteLine($"Wooo..! You guessed it right🎉\nIt took you {numOfGuesses} tries to guess it right");
          }
          else if (guess > magicNum)
          {
            Console.WriteLine("You guessed too high. Come down ⬇️");
          }
          else
          {
            Console.WriteLine("You guessed too low. Go up ⬆️");
          } 
           
        } while (isCorrect);

    }
}