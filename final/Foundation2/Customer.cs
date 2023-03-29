public class Customer:Address
{
    private string name;
    Address address = new Address();

    public void setName(string _name){
        name = _name;

    }
    public string getName(){
        return name;

    }

}