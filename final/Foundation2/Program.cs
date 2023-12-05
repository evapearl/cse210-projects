using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        Console.WriteLine("-------------------------");

        Address address1 = new Address ("23 Estate Lane", "Marcurdi", "Benue", "Nigeria");
        Customer customer1 = new Customer("Zenab", address1);

        double order1ShippingCost = customer1.GetShippingCost();

        Product order1Product1 = new Product("Dell E7440", "2134", 180, 2);
        Product order1Product2 = new Product("UBL 550", "1414", 12, 3);

        Order order1 = new Order(customer1);
        order1.AddProduct(order1Product1);
        order1.AddProduct(order1Product2);
        double order1Subtotal = order1.CalculateSubtotal();
        double order1Total = order1.CalculateTotal();

        order1.DisplayShippingLabel();
        Console.WriteLine();
        order1.DisplayPackingLabel();
        Console.WriteLine();
        order1.DisplayCosts(order1Subtotal, order1ShippingCost, order1Total);


        Console.WriteLine("-------------------------");

        Address address2 = new Address ("44 Jameswatt", "Bristol", "CT", "USA");
        Customer customer2 = new Customer("Alex Rex", address2);

        double order2ShippingCost = customer1.GetShippingCost();

        Product order2Product1 = new Product("Pizza", "4918", 3.00, 6);
        Product order2Product2 = new Product("Pineapple Juice", "4128", 1.00, 12);
        Product order2Product3 = new Product("Milk Shake", "4447", 1.10, 4);

        Order order2 = new Order(customer2);
        order2.AddProduct(order2Product1);
        order2.AddProduct(order2Product2);
        order2.AddProduct(order2Product3);
        double order2Subtotal = order2.CalculateSubtotal();
        double order2Total = order2.CalculateTotal();

        order2.DisplayShippingLabel();
        Console.WriteLine();
        order2.DisplayPackingLabel();
        Console.WriteLine();
        order2.DisplayCosts(order2Subtotal, order2ShippingCost, order2Total);

    }
}