using System.IO;

/// The Journal Class is responsible for managing all the journal entry.
/// It saves and loads these entries in a txt file. It saves the name of the 
/// file as well. Also, it stores the date of the entry.
public class Journal
{
    /// Initial the dateTime and fileName attributes 
    public string _date = "";
    public string _fileName = "";
    private string _filePath = $"journal/";
    private string txtName;

    public string fileAccessName (string fileName)
    {
        _fileName = fileName;
        txtName = _fileName.Replace(" ", "_").ToLower();
        _filePath += txtName;
        return _filePath;
    }

    
    // Creating the methods for the journal class.
    public string Entry ( string fileN = "")
    {
        using(StreamWriter outputFile = new StreamWriter($"{fileN}.txt"))
        {
            Console.WriteLine("Happy journaling 🤓..........");
            Console.WriteLine("");
            string output = Console.ReadLine();
            outputFile.WriteLine($"----------------------------------------------------- File Name: {_fileName}------------------------------------------------------------------\n-------------------------------------------------Date of Entry: {_date}--------------------------------------------------------\n{output}");
            Console.WriteLine("");
            Console.WriteLine("Your New Journal has been saved 📥");
        }
        return fileN;
    }

    private void Save (string content, string [] file, int option)
    {
        string choice = "q";
        do
        {
            Console.Write("Save Entry 📥 'y' | Continue Entry 📝 'n' | QUIT entry ❌ 'q': ");
            choice = Console.ReadLine().ToLower();
        
            if (choice == "y")
            {
                File.AppendAllText(file[option - 1], $" {content}\n");
                Console.WriteLine("\nYour entry has been saved 📥");
                break;
            } 
            else if (choice == "n")
            {  
                File.AppendAllText(file[option - 1], $"{content}");
                Console.WriteLine("\nLet's go 🚵🏼‍♀️:\n");
                content = Console.ReadLine();
            }
        } while (choice != "q");
        
    }
    public void Continue ()
    {
        string content;

        Display display = new Display();
        string [] files = display.CurrentFiles();

        Console.Write("\nChoose from the files above you would like to continue with: ");
        int option = int.Parse(Console.ReadLine());

        Console.WriteLine("\nHappy Journaling 🤓........\n");
        content = Console.ReadLine();
        Console.WriteLine("");

        Save(content, files, option);

    }

}
