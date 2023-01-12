using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers_list = new List<int>();
        
        int answer_user = -1;
        while (answer_user != 0)
        {
         Console.Write("Enter a list of numbers, type 0 to exit:");
        
        string answer = Console.ReadLine();
         answer_user = int.Parse(answer);
        
        if(answer_user !=0){
            numbers_list.Add(answer_user);
        }
        }
        int sum = 0;
        foreach(int number in numbers_list){
            sum = sum+number;
            //Console.WriteLine(numbers_list[number]);
        }
        Console.WriteLine($"The sum is:{sum}");

        float average = ((float)sum)/numbers_list.Count;
        Console.WriteLine($"The Average is:{Math.Round(average,2)}");

        int highest = numbers_list[0];

        for (int i = 0; i < numbers_list.Count; i++)
        {
            int number = numbers_list[i];
            if (number > highest)
            {
                highest = number;
            }
        }
        Console.WriteLine($"The Highest is:{highest}");
    }
    
}
