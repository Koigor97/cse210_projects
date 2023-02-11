using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!\n");
        
        Console.WriteLine("-------------------------------------- The Scripture Memorizer 📖-----------------------------------");
        Console.WriteLine("                     Welcome to the Scripture Memorizer App. Let's start memorizing!!                        \n");

        // Instanciating the reference class.
        // Because I'm using the instance of the reference class to get the values instead of a setter method,
        // I need to pass sort of a dummy parameters, and then give it new set of values to the parameters from the user.
        // I did it this way to avoid errors in my program.
        DisplayReference theReference = new DisplayReference("", 0, 0); 
        
        Console.Write("Enter the Scripture in the format - (Book, Chapter, Verse(s) separated by ',') : ");
        string[] listRef = Console.ReadLine().Split(",");
        
        // The if block statements are to count if the reference entered is a single verse or range of verses.
        // after I have split the user reference into list.
        if (listRef.Count() == 4)
        {
            // re-assigning the elements in the list to the reference class by it positional argument(parameters).
            theReference = new DisplayReference(listRef[0], int.Parse(listRef[1]), int.Parse(listRef[2]), int.Parse(listRef[3]));
        }
        if (listRef.Count() == 3)
        {
            theReference = new DisplayReference(listRef[0], int.Parse(listRef[1]), int.Parse(listRef[2]));
        }
         // Getting the verse or text from the user using the reference setter method.
        // But this setter method doesn't have a parameter to it. Instead it makes use of the readline.
        Console.WriteLine("Enter the scripture verse 📝:\n ");
        theReference.SetVerse();
        // Console.WriteLine(theReference.GetFormattedReference());
        // Console.WriteLine(theReference.GetTheVerse());
        Scripture scripture = new Scripture(theReference);
        
        string isQuit = "";
        while (isQuit != "quit")
        {
            scripture.HideWord(3);
            Console.Clear();
            scripture.DisplayText();

            Console.Write("Press Enter to continue 👉 and 'QUIT' to stop ❌ the program: ");
            isQuit = Console.ReadLine();
            

            if(scripture.IsAllWordHidden())
            {
                break;
            }
            
        }
        
        // *** The text below is a scripture reference of John 3:16-18. You can use for both single verse or
        // multiple range verses. Verse 17 starts from the '|'. You can just grab this to test the program ***
        // For God so loved the world, that he gave his one and only Son, that whoever believes in him should not perish, but have eternal life. | For God didn’t send his Son into the world to judge the world, but that the world should be saved through him. He who believes in him is not judged. He who doesn’t believe has been judged already, because he has not believed in the name of the one and only Son of God. 

            
    }
}
