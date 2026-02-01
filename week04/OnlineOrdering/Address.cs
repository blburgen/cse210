using System.Data;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool isUSA()
    {
        if(_country == "USA" || _country == "United States" || _country == "United States of America")
        {
            return true;
        }
        return false;
    }

    public string GetAddress()
    {
        string temp = $"{_street}\n";
        temp += $"{_city}, {_state}\n";
        temp += $"{_country}";
        return temp;
    }
}