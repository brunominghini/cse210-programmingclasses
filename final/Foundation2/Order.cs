public class Order:Product
{

    private double totalPrice;
    List<Product> listOrder = new List<Product>();
    Customer customer = new Customer();


    public void setProductOrder()
    {
    Console.Write (" Whats name of Product: ");
    string nameProduct = Console.ReadLine();
    setName(nameProduct);

    Console.Write ("How price unit of Product: ");
    double priceU = Convert.ToInt32(Console.ReadLine());
    setPriceU(priceU);

    Console.Write ("How many quantity of Product: ");
    int IdProduct = Convert.ToInt32(Console.ReadLine());

    double totalPrice = GetPrice();
    }
   
    public string getPackingLabel(){
        string nameProduct = getName();
        string parckingLabel ="ID: " + nameProduct;

        return parckingLabel;
    }

    public string getShippingLabel()
    {

        string shippingLabel = getName() + customer.GetFullAddress();

        return shippingLabel;
    }

}