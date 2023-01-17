using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Console.WriteLine("");

        // Instantiating the Job object
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Pathway Worldwide";
        job1._startYear = "2022";
        job1._endYear = "2023";
        // Displaying the job info
        job1.DisplayJobInfo();
        // Instantiating a sceond job instance
        Job job2 = new Job();
        job2._jobTitle = "Frontend Developer";
        job2._company = "LinkedIn";
        job2._startYear = "2023";
        job2._endYear = "2024";

        Console.WriteLine("");
        // Instantiatiing the Resume object.
        Resume resume = new Resume();
        resume._name = "Samuel F. Turay";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        // Displaying the user's resume info
        resume.Display();
        
    }

}