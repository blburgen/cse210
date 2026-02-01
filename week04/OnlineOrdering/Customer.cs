public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, string street, string city, string state, string country){
        _name = name;
        _address = new Address(street, city, state,country);
    }

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetAddress()
    {
        return $"{_name}\n{_address.GetAddress()}";
    }

    public bool IsUSA()
    {
        return _address.isUSA();
    }
}