using System.IO;
public class Journal{

public List<Entry> _journal = new List<Entry>();
    //Entry dateJournal = new Entry();    


    public string DisplayMenu()
    {   
        Console.WriteLine();
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
        //_journal.Add(datejournal.date);
        _journal.Add(new Entry {Date = DateTime.Now, Name = registers});
        Console.WriteLine();
    }

    public void Display()
    {
        Console.WriteLine("Your registers today:");
        foreach (var item in _journal){
          Console.WriteLine ($"{item.Date} - {item.Name}");
          Console.WriteLine();      
        }    
    }

    public void LoadJournal()
    {
        Console.WriteLine("You journal is loading");
        string filename = "Journal.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
        string[] parts = line.Split("-");
            if (parts.Length>2){

            string Date = parts[0];
            string Name = parts[1];
            }
        
            else
            {
                Console.WriteLine(line);
            }
        }
    }

    public void SaveJournal()
    {
        Console.WriteLine("You journal was saved");
        string filename = "Journal.txt";
        //string register;
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
        outputFile.WriteLine("Registers of Day.");
            foreach (var item in _journal){
            //register = Convert.ToString($"{item.Date}-{item.Name}");
            outputFile.WriteLine(Convert.ToString($"{item.Date} - {item.Name}"));
            }
        //outputFile.WriteLine($"{register}");
        }
    }
}


