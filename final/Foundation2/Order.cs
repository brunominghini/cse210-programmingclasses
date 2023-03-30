public class Order:Product
{
    
    List<Product> listOrder = new List<Product>();
    Customer customer = new Customer();

    public void SetCustomer(){
    Console.WriteLine("What the name of customer");
    string name = Console.ReadLine();
    customer.setName(name);
    }

    public void setProductOrder()
    {
    Product product = new Product();
    Console.Write (" Whats name of Product: ");
    string nameProduct = Console.ReadLine();
    product.setName(nameProduct);

    Console.Write ("How price unit of Product: ");
    double priceU = Convert.ToInt32(Console.ReadLine());
    product.setPriceU(priceU);

    Console.Write ("How many quantity of Product: ");
    int quantity = Convert.ToInt32(Console.ReadLine());
    product.setQuantity(quantity);
    
    product.GetPrice();

    listOrder.Add(product);       
    }

   
    public List<Product> getPackingLabel(){

        return listOrder;
    }

    public string getShippingLabel()
    {
        string shippingLabel = getName() + customer.GetFullAddress();
        return shippingLabel;
    }

    public double GetTotalPrice()
    { 
        double totalPrice = 0;

        foreach(Product product in listOrder){
            totalPrice += product.GetPrice();            
            }
    return totalPrice;
    }

}