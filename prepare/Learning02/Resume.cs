// The Resume class keeps track of the user name and a list of thier jobs.
// It behavior is to dispaly the user's name first, and then displays thier job(s).

public class Resume
{
    // Creating the attribute (object's state) of the class.
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    // Adding a method to display the user's name and job history.
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.DisplayJobInfo();
        }
    }
}