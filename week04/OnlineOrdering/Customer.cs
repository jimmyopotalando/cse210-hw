public class Customer
{
    private string name;
    private Address address;

    // Constructor
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    // Method to get the customer's name
    public string GetName()
    {
        return name;
    }

    // Method to check if the customer lives in the USA
    public bool IsInUSA()
    {
        return address.IsInUSA();
    }

    // Method to get the full address
    public string GetAddress()
    {
        return address.GetFullAddress();
    }
}
