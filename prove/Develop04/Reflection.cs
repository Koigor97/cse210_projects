// The Reflection class also inherits from the Asset class. It is responsible for letting the user reflects and ponder on randomly generated prompts. 

public class Reflection : Assets
{
    private string _activityName = "Reflection";
    private string _introMsg = "Take a few moments to reflect on your experiences and insights. This activity will guide you through thoughtful questions to help you gain perspective and cultivate gratitude.";

    private string _questionFileName = "questionPrompts.txt";
    private string _followUpFileName = "followUpPrompts.txt";

    public Reflection () : base()
    {
    }

    public string GetActivityName()
    {
        return _activityName;
    }
    public void ReflectionPrompt()
    {   
        WelcomeMsg(_activityName, _introMsg);
        Console.WriteLine($"Consider the following prompt:\n\n---- {GetPrompt(GetUsedPrompts(), _questionFileName)} ----");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Clear();
    }

    public void PonderPrompts()
    {
        Console.Write($"> {GetPrompt(GetUsedFollowUp(), _followUpFileName)} ");
        GetAnimation(GetTimer() + 3);
        Console.Write($"> {GetPrompt(GetUsedFollowUp(), _followUpFileName)} ");
        GetAnimation(GetTimer() + 3);
        CompletionMsg(GetSessionTime(), _activityName);
    }
}