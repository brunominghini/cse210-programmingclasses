

class ShowingScripture{

    
    private string _randomScripture;
    Scripture scripture = new Scripture();
    Reference reference = new Reference();

    public ShowingScripture()
    {   
        Console.WriteLine("Write the Scripture that you desire memorazy?");
        scripture.SetScripture(Console.ReadLine());

        Console.WriteLine("What reference?");
        //reference.SetReference(Console.ReadLine());

        //_randomScripture = reference.GetReference()+" "+scripture.GetScripture();

    }
}

