using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write the follwing informations:");
        
        Console.WriteLine("Goal:");
        string _goal = Console.ReadLine();

        Console.WriteLine("Time: ex.:1week, 1month, 3day");
        string _time = Console.ReadLine();

        Console.WriteLine("Point: ex.:10, 20, 100");
        double _point = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Score Goal to receive Reward:");
        double _score = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Objective ex.: Obtain better stregthen phisical");
        string _objective = Console.ReadLine();

        Console.WriteLine("Description:");
        string _description = Console.ReadLine();

        double _pontuation = 0;

    
        Objective obj  = new Objective(
            _goal,
            _time,
            false,
            _point,
            _score,
            _objective,
            _description,
            "",
            0);


        do 
        {
            Console.WriteLine("Write if you achieved this goal? checked: 1-Yes/0-No ");
            string answer = Console.ReadLine();
            if (_pontuation >= _score){
                Console.WriteLine($"Congratulation, You achieved the score{_pontuation}, and your score is {_score}, You reward is");

            }
            else if (answer == "1")
            {
                //_pontuation = obj.GetGoal();
                _pontuation =_pontuation+_point;
            }
            
            else if(answer =="0"){
            Console.WriteLine("Don't give up");
            }

        }
        while (_pontuation <= _score);

    }
}