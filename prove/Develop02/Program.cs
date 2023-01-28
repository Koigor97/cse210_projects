using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime currentDateTime = DateTime.Now;
        
        Console.WriteLine("---------------------------- Welcome to Easy Journal 📔 -------------------------------");
        Console.WriteLine("         What can I do for you today 😎 (select the option by it number)                             ");
        Console.WriteLine("");
        //Initiating the Journal object
        Journal journal = new Journal();
        // Initiating the Display object
        Display display = new Display();

        
        int theResponse;

        do
        {
            display.ShowMenu();
            theResponse = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (theResponse == 1)
            {
                Console.WriteLine("What is the name of the Journal");
                string entryName = Console.ReadLine();
                
                journal._fileName = entryName;
                journal._date = currentDateTime.ToLongDateString();
                journal.Entry(journal.fileAccessName(journal._fileName));
            }
        
            else if (theResponse == 2)
            {
                journal.Continue();
            }

            else if (theResponse == 3)
            {
                display.LoadJournal();
            }

            else if (theResponse == 4)
            {
                display.FileDelete();
            }
        } while (theResponse != 5);
        
    }
} 