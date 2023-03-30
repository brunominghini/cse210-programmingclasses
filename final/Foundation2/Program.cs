using System;

class Program
{
    static void Main(string[] args)
    {
        int option=1;
        Order order = new Order();
       
        order.SetCustomer();
        string name = order.getName();

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
         

        while (option!=0){
        Console.WriteLine("Chosse the option");
        Console.WriteLine("0 - Exit");
        Console.WriteLine("1- Add new item");
        Console.WriteLine("2- Total Price"); 

        option = Convert.ToInt32(Console.ReadLine());

        if (option == 1)
        {
            order.setProductOrder();
        }
        else if (option == 2)
        {
            double totalPrice = order.GetTotalPrice();
            string shippingLabel = order.getShippingLabel();
            


            Console.WriteLine($"name:{name}");

            Console.WriteLine(FullAdress);
            
            Console.WriteLine("List Order:");
            Console.WriteLine(order.getPackingLabel());
            Console.WriteLine ($"Total Price:{totalPrice}");
            Console.WriteLine($"{shippingLabel}");
            
        }
        else if (option > 2)
        {
            Console.WriteLine("Chosse the correct option:");
        }
        else if (option == 0)
        {
            Console.WriteLine("Welcome");
        }
        }


    }
}