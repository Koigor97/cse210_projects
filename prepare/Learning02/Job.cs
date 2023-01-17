// The Job class has the responsibility of keeping track of the company,
// job title, the start year and end year of the user. With the behavior to 
// display the job info in this format "Job title (Company) StartYear-EndYear".

public class Job
{
    // Attributes (object's state) of the class.
    public string _jobTitle = "";
    public string _company = "";
    public string _startYear = "";
    public string _endYear = "";

    // Adding a method (member function) to display the job info.
    public void DisplayJobInfo() => Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
}