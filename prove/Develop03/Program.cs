using System;

class Program
{
    static void Main(string[] args)
    {   
        Scripture scripture = new Scripture();
        Reference reference = new Reference();

        Console.WriteLine("Write the Scripture that you desire memorazy?");
        scripture.SetScripture(Console.ReadLine());

        Console.WriteLine("What reference?");
        reference.SetReference(Console.ReadLine());


        Console.WriteLine(reference.GetReference()+": "+scripture.GetScripture());

    }
}