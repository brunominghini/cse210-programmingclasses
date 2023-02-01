using System.IO;

class Program
{
    static void Main(string[] args)
    {
        
        Journal journal = new Journal();
        GeneralPrompt prompt = new GeneralPrompt();
       

        int chose=-1;
        while (chose != 5){
        chose = int.Parse(journal.DisplayMenu());
        
        if (chose == 1){
            prompt.DisplayPrompts();
            journal.Add_Entry(Console.ReadLine()+".");
        }

        if (chose == 2){
            journal.Display();
        }

        if (chose == 3){
            journal.LoadJournal();
        }

        if (chose==4){
            journal.SaveJournal();
        }

        if (chose==5){
            Console.WriteLine("Closing the Journal");
            };
        }
    }
}