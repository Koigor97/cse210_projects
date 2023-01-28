// The responsibilty of the Display class is to print on the console
// This class works hand in glove with Journal class and the main program.

public class Display 
{
    // this class has no attributes
    private string _filePath = $"journal/";
    public void ShowMenu()
    {
        Console.WriteLine("\n1.New Journal 📓 | 2.Continue 📝 | 3.Load Journal 📖 | 4.Delete Journal 🚮 | 5.Quit ❌");
    }

    public string [] CurrentFiles()
    {
        int indexNum = 0;  
        var files = Directory.GetFiles(_filePath);
        Console.WriteLine("These are the files 📑 in your Journal Folder 🗂️:");
        foreach (string file in files)    
        {
            indexNum ++;
            Console.WriteLine($"---------------------------  {indexNum}. {Path.GetFileNameWithoutExtension(file)} 📄  -----------------------------");
        }
        return files;
    }

    public void LoadJournal ()
    {
        string [] file = CurrentFiles();
        Console.Write("\nWhich file 📄 do you want to load ?: ");
        int userChoice = int.Parse(Console.ReadLine());

        string fileContent = File.ReadAllText(file[userChoice - 1]);
        Console.WriteLine($"\n{fileContent}");
        Console.WriteLine("\n------------ Your file 📄 has been loaded ✅ ----------------\n");

    }

    public void FileDelete ()
    {
        string [] file = CurrentFiles();
        Console.Write("\nWhich file 📄 do you want to load ?: ");
        int userChoice = int.Parse(Console.ReadLine());

        string delete = file[userChoice - 1];
        if (File.Exists(delete))
        {
            Console.WriteLine($"\n{Path.GetFileNameWithoutExtension(delete)} has been DELETED 🗑️");
            File.Delete(delete);
        }
        else
        {
            Console.WriteLine("File 📄 doesn't exist.");
        }
    }
}