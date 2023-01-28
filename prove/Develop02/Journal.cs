
public class Journal{

public string register;
public List<GeneralPrompt> prompts= new List<GeneralPrompt>();

    public string DisplayMenu()
    {   
        Console.WriteLine("Please select the option:");
        Console.WriteLine("1.Write");
        Console.WriteLine("2.Display");
        Console.WriteLine("3.Load");
        Console.WriteLine("4.Save");
        Console.WriteLine("5.Quit");

        string chose = Console.ReadLine();
     
        return chose;
    }

    public string Add_Entry(DateTime date)
    {
        string register = Console.ReadLine();

        return register;
    }

    public void Display()
    {
        Console.WriteLine("Your registers");
    }

    public void LoadJournal()
    {
        Console.WriteLine("You journal is loading");
    }

    public void SaveJournal()
    {
        Console.WriteLine("You journal is save");
    }
}


