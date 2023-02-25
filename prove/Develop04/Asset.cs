using System.IO;
using System.Collections.Generic;
using System.Threading;
// The Asset Class is the base for all the other classes.
// This is responsible for displaying the countdown timer, displaying the animation,
// also responsible for managing random prompts for the specified classes.

public class Assets 
{
    private string _promptsPath = "prompts/";
    private List<string> _UsedPrompts  = new List<string>();
    private List<string> _UsedFollowUp = new List<string>();
    private List<string> _UsedListing = new List<string>();
    private int _sessionTime;
    private string _userName = "Buddy";

    private int theTimer;

    private string[] _animation = {"|", "/", "-", "\\", "|", "/", "-", "\\"};
    
    public Assets (string name = "", int session = 0)
    {
        _userName = name;
        _sessionTime = session;
    }

    public void SetUserName () {
        Console.Write("Enter your name 😊: ");
        _userName = Console.ReadLine();
        Console.Clear();
    }

    public void SetSessionTime () 
    {
        Console.Write("Enter the duration of your session in seconds ⏱️ : ");
        _sessionTime = int.Parse(Console.ReadLine());
        
    }
    public string GetUserName ()
        {
            return _userName;
        }
    public void WelcomeMsg(string activity, string msg)
    {
        Console.WriteLine($"Welcome to the {activity} Activity.\n");
        Console.WriteLine($"{msg}\n");
        SetSessionTime();
        theTimer = GetSessionTime() / 6;
        Console.Clear();
        Console.WriteLine("Get ready...");
        GetAnimation(theTimer);

    }

    public void CompletionMsg (int session, string activity)
    {
        Console.WriteLine($"\nWell done!!! {GetUserName()}");
        Console.WriteLine($"You have completed another {session} seconds of the {activity} Activity.");
        GetAnimation(theTimer);
        Console.Clear();
    }

    public string GetPrompt (List<string> theList, string file)
    {
        Random random = new Random();
        List<string> prompts = new List<string> ();
         prompts.AddRange(File.ReadAllLines($"{_promptsPath}/{file}"));
        int randomIndex = random.Next(prompts.Count());
        string thePrompt = prompts[randomIndex];
        theList.Add(thePrompt);
        prompts.RemoveAt(randomIndex);
        if (prompts.Count() == 0)
        {
            prompts.AddRange(theList);
        }
        return thePrompt;
    }

    public void CountDown (int num)
    {
        DateTime date = DateTime.Now;
        DateTime future = date.AddSeconds(num);
        do 
        { 
          Console.Write(num--);
          Thread.Sleep(1000);
          Console.Write("\b \b");
          date = DateTime.Now;
        } while (date < future);
        Console.WriteLine("");
    }

    public void GetAnimation (int num) 
    {
        DateTime date = DateTime.Now;
        DateTime future = date.AddSeconds(num);
        int i = 0;
        do
        {
          Console.Write($"{_animation[i]}");
          Thread.Sleep(1000);
          Console.Write("\b \b");
          i++;  
          if(i >= _animation.Count())
          {
              i = 0;       
          }
          date = DateTime.Now;
        } while(date < future);
        Console.WriteLine("");
    }
    
    public int GetSessionTime ()
    {
        return _sessionTime;
    }

    public List<string> GetUsedPrompts ()
    {
        return _UsedPrompts;
    }

    public List<string> GetUsedFollowUp ()
    {
        return _UsedFollowUp;
    }

    public List<string> GetUsedList ()
    {
        return _UsedListing;
    }

    public int GetTimer()
    {
        return theTimer;
    }

}