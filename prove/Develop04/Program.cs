using System;

class Program
{
    static void Main(string[] args)
    {
        Assets asset = new Assets();
        Breathing breathing = new Breathing();
        Reflection reflection = new Reflection();
        Listing listing = new Listing();
        Console.WriteLine("\n--------------------------- ⊰ Welcome To The Mindfulness Activity ⊱ -------------------------\n");
        Console.WriteLine("\n-------------------------🪧 (Select the Activity that you want by it number) 🪧 -------------------------\n");
        asset.SetUserName();
        int userChoice;
        
        do
        {
          Console.WriteLine("1. Start Breathing Activity 🫁 | 2. Start Refelecting Activity 🧘🏽‍♀️ | 3. Start Listing Activity 📝 | 4. Quit ❌\n");
          Console.Write("Select your activity: ");
          userChoice = int.Parse(Console.ReadLine()); 
          Console.WriteLine("");

          if (userChoice == 1)
          {
            breathing.Breath();
            Console.WriteLine("");
          }
          else if(userChoice == 2)
          {
            reflection.ReflectionPrompt();
            reflection.PonderPrompts();
          }
          else if (userChoice == 3)
          {
            listing.DisplayListItem();
            listing.ListAmount();
          }

        } while (userChoice != 4);
        
    }
}