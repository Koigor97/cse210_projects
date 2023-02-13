//  This class inherit from the Assignment Class.
public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string bookSection, string problem) : base (name, topic)
    {
        _textBookSection = bookSection;
        _problems = problem;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }
}