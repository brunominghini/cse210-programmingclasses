using System;

class Program
{
    static void Main(string[] args)
    {   string typeEvent;
        int option = 0;
        string details;
        Event event1 = new Event();
        Console.WriteLine("Hello, Welcome to plan the Event!");
        Console.WriteLine("Type of event: \n Lecture \n Reception \n Outdoor");
        typeEvent = Console.ReadLine();
    
        Console.WriteLine("What title of event:");
        string title = Console.ReadLine();

        Console.WriteLine("What Description of event:");
        string description = Console.ReadLine();

        Console.WriteLine("What Date of event:");
        string dateTime = Console.ReadLine();

        Console.WriteLine("What Address of event:");
        string address = Console.ReadLine();
        Console.WriteLine("");

        
        Console.WriteLine("");

        if (typeEvent == "Lecture")
        {
            Lecture lecture = new Lecture();
            Console.WriteLine("What Speaker");

            string speaker = Console.ReadLine();
            lecture.SetSpeaker(speaker);

            Console.WriteLine("What capacity:");
            int capacity = Convert.ToInt16(Console.ReadLine());
            lecture.SetCapacity(capacity);

            string lectureDetails = lecture.LectureDetails();

            lecture.CreatEvent(typeEvent,title, description, dateTime, address);
            
            Console.WriteLine("Whats type of information that you desire:");
            Console.WriteLine(" 1- Standard details \n 2- Full details \n 3- Short description");

            option = Convert.ToInt16(Console.ReadLine());
            
            if (option == 1)
            {
                details = lecture.EventStandardDetails();
                Console.WriteLine($"Standard Details \n {typeEvent} - {details}");
            }
            else if (option == 2)
            {
                details = lecture.EventFullDetails();
                Console.WriteLine($"Full Details\n {typeEvent}:{lectureDetails}\n{details}");
            }
            else if (option == 3){
                details = lecture.ShortDescription();
                Console.WriteLine($"Short description \n {typeEvent} - {details}");
            }

            
        }
        else if (typeEvent == "Reception")
        {
            Receptions reception = new Receptions();
            Console.WriteLine("What E-mail para RSVP:");
            string email = Console.ReadLine();
            reception.SetEmail(email);
            email = reception.GetEmail();

            reception.CreatEvent(typeEvent,title, description, dateTime, address);
            Console.WriteLine("Whats type of information that you desire:");
            Console.WriteLine("1- Standard details \n 2- Full details \n 3- Short description");
            
            option = Convert.ToInt16(Console.ReadLine());

            if (option == 1)
            {
                details = reception.EventStandardDetails();
                Console.WriteLine($"Standard Details:{typeEvent} \n{details}");
            }
            else if (option == 2)
            {
                details = reception.EventFullDetails();
                Console.WriteLine($"Full Details\n {typeEvent}: Email RSVP{reception.GetEmail}\n{details}");
            }
            else if (option == 3){
                details = reception.ShortDescription();
                Console.WriteLine($"Short description \n {typeEvent} - {details}");
            }
        }
        else if (typeEvent == "outdoor" )
        {
            Outdoor outdoor = new Outdoor();
            Console.WriteLine("What Weather:");
            string weather = Console.ReadLine();
            outdoor.SetWeather(weather);
            weather = outdoor.WeatherStatement();
            outdoor.CreatEvent(typeEvent, title, description, dateTime, address);
            Console.WriteLine("Whats type of information that you desire:");
            Console.WriteLine(" 1- Standard details \n 2- Full details \n 3- Short description");

            option = Convert.ToInt16(Console.ReadLine());
           if (option == 1)
            {
                details = outdoor.EventStandardDetails();
                Console.WriteLine($"Standard Details:{typeEvent} \n{details}");
            }
            else if (option == 2)
            {
                details = outdoor.EventFullDetails();
                Console.WriteLine($"Full Details\n {typeEvent}: Email RSVP{outdoor.WeatherStatement}\n{details}");
            }
            else if (option == 3){
                details = outdoor.ShortDescription();
                Console.WriteLine($"Short description \n {typeEvent} - {details}");
            }
        }
    }
}