// The Breathing Class inherits from the Asset class. It is responsible
// for giving the user a breathing session base on the duration of the session.

public class Breathing : Assets
{
    private string _activityName = "Breathing"; 
    private string _introMsg = "This guided practice will help you relax and find calmness by focusing on slow and intentional breathing. Let's begin.";

    public Breathing ()
    {
    }
    public void Breath ()
    {
        WelcomeMsg(_activityName, _introMsg);
        int breathingLength = GetTimer();
        int numOfInterval = 6;
        do
        {
            Console.Write("breathe IN...😌 ");
            CountDown(breathingLength);
            Console.Write("breathe OUT...😮‍💨 ");
            CountDown(breathingLength);
            Console.WriteLine("");
            numOfInterval--;
        } while (numOfInterval >= 0);
        CompletionMsg(GetSessionTime(), _activityName);
    }
}