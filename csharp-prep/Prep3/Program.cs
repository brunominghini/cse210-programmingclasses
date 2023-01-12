using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        /*Console.Write("What is a magic number?");
        string number = Console.ReadLine();*/
        int magic_number = randomGenerator.Next(1,100);
        int guess_number;
        /*To test 
        Console.WriteLine($"{magic_number}");*/
        
        do{
             Console.Write("What is your guess?");
            string answer = Console.ReadLine();
            guess_number = int.Parse(answer);
            if (guess_number > magic_number){
                Console.WriteLine("Higher");

            } 
            else if(guess_number<magic_number){
                Console.WriteLine("Lower");                
            }
            else if(guess_number==magic_number){
                Console.WriteLine("You guessed it!");
            }
        }
        while (guess_number != magic_number);


    }
}