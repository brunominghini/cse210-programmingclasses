using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write the follwing informations:");

        Objective obj  = new Objective(
            "teste",
            "7 days",
            false,
            1,
            1,
            "teste",
            "teste",
            "description",
            100);
        
        obj.setScore(100);
        obj.setPoint(2);
        
        double pontuation = obj.GetGoal();
        
        Console.WriteLine(pontuation);
    }
}