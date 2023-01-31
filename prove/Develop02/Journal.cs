
public class Journal{

public List<String> _journal = new List<String>();
Entry dateJournal = new Entry();

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

    public void Add_Entry(string registers)
    {
        //_journal.Add(dateJournal.date);
        _journal.Add(registers);
    }

    public void Display()
    {
        Console.WriteLine("Your registers:");
        Console.WriteLine ($"{_journal}");
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


