using System;

class Program
{
    static void Main(string[] args)
    {
        string registered;
        Journal journal = new Journal();
        GeneralPrompt prompt = new GeneralPrompt();
        Entry entry = new Entry();



        string chose = journal.DisplayMenu();

        if (chose == "1"){
            prompt.DisplayPrompts();

            registered = journal.Add_Entry(entry.date);
        }

        if (chose=="2"){
            journal.SaveJournal();
        }
        
    }
}