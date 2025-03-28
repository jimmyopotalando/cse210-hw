public class Product
{
    private string name;
    private int productId;
    private double price;
    private int quantity;

    // Constructor
    public Product(string name, int productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    // Method to get the product's name
    public string GetName()
    {
        return name;
    }

    // Method to get the product's ID
    public int GetProductId()
    {
        return productId;
    }

    // Method to calculate the total cost for this product
    public double GetTotalCost()
    {
        return price * quantity;
    }
}
