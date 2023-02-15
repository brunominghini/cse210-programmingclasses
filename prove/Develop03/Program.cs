using System;

class Program
{
    static void Main(string[] args)
    {   //ShowingScripture randomScripture = new ShowingScripture();
        
        
        string option = "";
        Scripture scripture = new Scripture();
        Reference reference = new Reference();

        Console.WriteLine("Write the Scripture that you desire memorazy?");
        scripture.SetScripture(Console.ReadLine());

        Console.WriteLine("What reference?");
        reference.SetVerse(Console.ReadLine());

        Console.WriteLine(reference.GetVerse() + reference.GetText()+": "+scripture.GetScripture());

        
        
        do
        {
         Console.WriteLine ("to press the enter key or type quit:");
            option = Console.ReadLine();
            Console.WriteLine(reference.GetVerse() + reference.GetText()+": "+scripture.GetScripture());

        }
        while(option == "quit");
        
        Console.WriteLine("exiting");
        

    
        
    }
}