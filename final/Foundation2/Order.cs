using System;

public class Order 
{
    private List<Product> _products = new List<Product>();
    private Customer _customer {get; set;}

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateSubtotal()
    {
        double subtotal = 0;
        foreach (Product product in _products)
        {
            double productPrice = product.CalculatePrice();
            subtotal += productPrice;
        }
        return subtotal;
    }

    public double CalculateTotal()
    {
        double total = CalculateSubtotal() + _customer.GetShippingCost();
        return total;
    }

    public void DisplayCosts(double subtotal, double shippingCost, double total)
    {
        Console.WriteLine($"Subtotal : ${subtotal}");
        Console.WriteLine($"Shipping: ${shippingCost}");
        Console.WriteLine($"Total : ${total}");
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine("Packing Label");
        foreach (Product product in _products)
        {
            product.DisplayProductDetails();
        }
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine("Shipping Label");
        Console.WriteLine("Ship to: ");
        _customer.DisplayCustomer();
    }
}