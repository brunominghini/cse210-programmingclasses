public class Product{

    private string name;
    private int product;
    private double priceU;
    private int quantity;

    public void setName(string _name)
    {
        name = _name;
    }
    public string getName()
    {
        return name;
    }

    public void setProduct(int _product)
    {
        product = _product;
    }
    public int getProduct()
    {
        return product;
    }

     public void setPriceU(double _priceU)
    {
       priceU = _priceU;
    }
    public double getPriceU()
    {
        return priceU;
    }

     public void setQuantity(int _quantity)
    {
        quantity = _quantity;
    }
    public int getQuantity()
    {
        return quantity;
    }
    
    public double GetPrice(){

        double price;

        double priceU = getPriceU();
        double quantity = getQuantity();

        price = priceU * quantity;
        
        return price;
    }



    

}