public class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    public void setStreet(string _street)
    {
        street = _street;
    }
    public string getStreet()
    {
        return street;
    }

    public void setCity(string _city)
    {
        city = _city;
    }
    public string getCity()
    {
        return city;

    }
    public void setState(string _state)
    {
        state = _state;

    }
    public string getState()
    {
        return state;

    }
    public void setCountry(string _country)
    {
        country = _country;
    }
    public string getCountry()
    {
        return country;
    }
    public string GetFullAddress()
    {
        string Address;
        /*
        setStreet(_street);
        setCity (_city);
        setState(_state);
        setCountry (_country);
        */

        string street = getStreet();
        string city = getCity();
        string state = getState();
        string country = getCountry();

        Address = street + " - " + city + " / " + state + "\n" + country;

        return Address;
    }

}