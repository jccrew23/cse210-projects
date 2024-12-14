using System;

class Program
{
    static void Main(string[] args)
    {
        //order 1 
        Order order1 = new Order();
        Address address1 = new Address();
        address1.SetAddress("161 Mill Road", "Raleigh", "North Carolina", "United States");

        Customer customer1 = new Customer();
        customer1.SetName("John Powell");
        customer1.SetAddress(address1);
        order1.SetCustomer(customer1);

        Product product11 = new Product();
        product11.SetProduct("hairdryer", 1123, 34.99, 1);
        order1._orderProducts.Add(product11);

        Product product12 = new Product();
        product12.SetProduct("makeup brushes",1224,10.49,2);
        order1._orderProducts.Add(product12);

        double total1 = order1.TotalCost();
        string packLabel1 = order1.ProvidePackingLabel();
        string shipLabel1 = order1.ProvideShippingLabel();

        Console.WriteLine( $"Order1: {total1}\nPackingLabel: {packLabel1}\nShipping Label: {shipLabel1}");

        //order 2
        Order order2 = new Order();
        Address address2 = new Address();
        address2.SetAddress("5540 Main Street", "Richmond", "Virginia", "United States");

        Customer customer2 = new Customer();
        customer2.SetName("Trina Hairston");
        customer2.SetAddress(address2);
        order2.SetCustomer(customer2);

        Product product21 = new Product();
        product21.SetProduct("Chocolate Frog", 2123, 5.99, 5);
        order2._orderProducts.Add(product21);

        Product product22 = new Product();
        product12.SetProduct("Bertie Botts Every Flavor Beans",2224,7.99,3);
        order2._orderProducts.Add(product22);

        double total2 = order1.TotalCost();
        string packLabel2 = order2.ProvidePackingLabel();
        string shipLabel2 = order2.ProvideShippingLabel();

        Console.WriteLine( $"Order1: {total2}\nPackingLabel: {packLabel2}\nShipping Label: {shipLabel2}");



    }
}