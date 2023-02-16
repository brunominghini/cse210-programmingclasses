using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assigment = new Assignment("Bruno Minghini","Multiplication");
        Console.WriteLine(assigment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Bruno Minghini", "Calc", "2.0", "10");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Angela Pedreira", "Brazil History", "The Colonization");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());


    }
}