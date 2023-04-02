using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello to manager your Health");

        Console.WriteLine("What date of activity: ");
        string date = Console.ReadLine();

        Console.WriteLine ("What the activity:");
        string activity = Console.ReadLine();

        if (activity.ToLower() == "swimming")
        {  
            Console.WriteLine ("What duration (in minutes) of your Activity:");
            double duration = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine ("What laps you complete:");
            double laps = Convert.ToDouble(Console.ReadLine());
            Swimming swimming = new Swimming();
            swimming.setLaps(laps);
            double distance = swimming.CalculateDistance();

            Console.WriteLine($"{date}, SWIMMING {duration}min e Laps:{laps} = Distance {distance}");

        }else if (activity.ToLower() == "cycling")
        {  
            Console.WriteLine ("What duration (in minutes) of your Activity:");
            double duration = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine ("What Distance");
            double distance = Convert.ToDouble(Console.ReadLine());
            Cycling cycling = new Cycling();
            cycling.setDuration(duration);
            cycling.setDistance(distance);
            double speed = cycling.CalculateSpeed();
            double pace  = cycling.CalculatePace();

            Console.WriteLine($"{date}, CYCLING {duration}min e Distace {distance} = Speed: {speed} Km/h and Pace: {pace}" );

        }
        else if (activity.ToLower() == "running")
        {  
            Console.WriteLine ("What duration (in minutes) of your Activity:");
            double duration = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine ("What Distance");
            double distance = Convert.ToDouble(Console.ReadLine());
            Running running = new Running();
            running.setDuration(duration);
            running.setDistance(distance);
            double speed = running.CalculateSpeed();
            double pace  = running.CalculatePace();

            Console.WriteLine($"{date}, RUNNING {duration}min e Distace {distance} = Speed {speed} Km/h and Pace {pace}" );

        }

    }
}