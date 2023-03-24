using System;

class Program
{
    static void Main(string[] args)
    {

        Address address = new Address();
        Console.WriteLine("What your Full Address");
        Console.Write("Street:");
        string street  = Console.ReadLine();
        address.setStreet(street);

        Console.Write("City:");
        string city  = Console.ReadLine();
        address.setCity(city);

        Console.Write("State:");
        string state  = Console.ReadLine();
        address.setState(state);

        Console.Write("Country:");
        string country  = Console.ReadLine();
        address.setCountry(country);

        string FullAdress = address.GetFullAddress();
        Console.WriteLine(FullAdress);
    }
}