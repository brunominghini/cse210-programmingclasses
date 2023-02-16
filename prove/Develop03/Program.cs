using System;

class Program
{
    static void Main(string[] args)
    {   //ShowingScripture randomScripture = new ShowingScripture();
        
        string scripture = string.Empty;
        string reference = string.Empty;
        string text = string.Empty;
        string option = "";
        List<Reference> references = new List<Reference>();
        

        Console.Write("Write the Scripture that you desire memorazy?");
        scripture = Console.ReadLine();

        Console.Write("What reference?");
        reference = Console.ReadLine();

        Console.Write("What text?");
        text = Console.ReadLine();        

        references.Add(new Reference(reference, text));
        Scripture book = new Scripture(references, scripture);

        foreach (var item in book._Reference){
          Console.WriteLine ($"{scripture} {book._Reference[0].GetVerse}");
          Console.WriteLine();      
        }
        
        do
        {
         Console.WriteLine ("to press the enter key or type quit:");
            option = Console.ReadLine();
            //Console.WriteLine(reference.GetVerse() + "=" +reference.GetText());

        }
        while(option == "quit");
        
        Console.WriteLine("exiting");
        

    
        
    }
}