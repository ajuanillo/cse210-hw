using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        //order1
        string custName="Alonso G Salazar";
        string custAddressStreet="Saint Av";
        string custAddressCity="Seattle";
        string custAddressState="Washington";
        string custAddressCountry="USA";

        Address address1=new Address(custAddressStreet, custAddressCity, custAddressState, custAddressCountry);
        Customer customer1=new Customer(custName,address1);

        string custName1="Alfredo Juanillo";
        string custAddressStreet1="Av Deporte";
        string custAddressCity1="Tacna";
        string custAddressState1="Tacna";
        string custAddressCountry1="Peru";

        Address address2=new Address(custAddressStreet1, custAddressCity1, custAddressState1, custAddressCountry1);
        Customer customer2=new Customer(custName1,address2);


        //Order 01
        string productName1="Coca Cola";
        int productId1=1001;
        int productPrice1=5;
        int quantity1=7;

        string productName2="Inka Cola";
        int productId2=1002;
        int productPrice2=3;
        int quantity2=18;

        Product product1=new Product(productName1, productId1, productPrice1,quantity1);
        Product product2=new Product(productName2, productId2, productPrice2, quantity2);   
        
        Order order1=new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        //order2
         productName1="Science Book";
         productId1=2003;
         productPrice1=105;
         quantity1=2;

         productName2="Site Reliability Engineer Book";
         productId2=2002;
         productPrice2=98;
         quantity2=3;

        string productName3="Time Management Book";
        int productId3=2010;
        int productPrice3=50;
        int quantity3=4;

        Product product3=new Product(productName1, productId1, productPrice1, quantity1);
        Product product4=new Product(productName2, productId2, productPrice2, quantity2);
        Product product5=new Product(productName3, productId3, productPrice3, quantity3);
        Order order2=new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);


        Console.Clear();
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.CalculateTotalCost().ToString());
        Console.WriteLine("-------------------------------------------------\n");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.CalculateTotalCost().ToString());

    }
}