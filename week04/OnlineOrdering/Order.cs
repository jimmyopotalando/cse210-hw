using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;
    private const double domesticShippingCost = 5.0;
    private const double internationalShippingCost = 35.0;

    // Constructor
    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // Method to calculate the total cost of the order
    public double GetTotalCost()
    {
        double totalCost = 0.0;

        foreach (var product in products)
        {
            totalCost += product.GetTotalCost();
        }

        // Add shipping cost
        double shippingCost = customer.IsInUSA() ? domesticShippingCost : internationalShippingCost;
        totalCost += shippingCost;

        return totalCost;
    }

    // Method to get the packing label (lists each product's name and ID)
    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";

        foreach (var product in products)
        {
            packingLabel += $"{product.GetName()} (Product ID: {product.GetProductId()})\n";
        }

        return packingLabel;
    }

    // Method to get the shipping label (lists customer's name and address)
    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"{customer.GetName()}\n{customer.GetAddress()}";

        return shippingLabel;
    }
}
