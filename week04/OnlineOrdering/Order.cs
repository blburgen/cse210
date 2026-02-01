public class Order
{
    private Customer _customer;
    private List<Product> _productList;

    public Order(Customer customer, List<Product> productList)
    {
        _customer = customer;
        _productList = productList;
    }

    public double GetTotalCost()
    {
        double temp = 0;
        foreach(Product item in _productList)
        {
            temp += item.GetCost();
        }
        if (_customer.IsUSA())
        {
            temp += 5;
        }
        else
        {
            temp += 35;
        }
        return temp;
    }

    public string GetPackingLable()
    {
        string temp = "Packing Lable\n";
        temp += "Product(Product ID) - count\n";
        foreach(Product item in _productList)
        {
            temp += $"{item.GetProduct()}\n";
        }
        return temp;
    }

    public string GetShippingLabel()
    {
        string temp = "Shipping Lable\n";
        temp += _customer.GetAddress();
        return temp;
    }

}