using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string name = MessageUser();
        int number = UserNumber();
        int square = Square(number);
        ShowMessage(name, square);
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Hello World!");
    }

    static string MessageUser()
    {
        Console.WriteLine("Please Enter Name:");
        string name = Console.ReadLine();

        return name;  
    }

    static int UserNumber()
    {
        Console.WriteLine("Enter Number:");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int Square(int number)
    {
        int square = number * number;
        return square;
    }


    static void ShowMessage(string name, int square)
    {
        Console.WriteLine($"{name}, the square the number is {square}");
    }
}