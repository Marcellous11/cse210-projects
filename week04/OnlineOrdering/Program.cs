using System;
namespace OnlineOrdering;
class Program
{
    static void Main(string[] args)
    {
        Address jamesBondAddress = new Address("3245 One Shot Dr","Frisco","TX","USA" );
        Customer jamesBond = new Customer("James Bond",jamesBondAddress);

        Product shoes = new Product("Nike SB",199.99,1);
        Product shirt = new Product("Banana Republic Shirt",36.99,3);
        Product jacket = new Product("Express Fly Jacket",89.99,1);
        
        Order order1 = new Order(jamesBond,new List<Product>(){shoes,shirt,jacket});


        Address OJAddress = new Address("3422 Guilty Ave","Nowhere","Darkness","China" );
        Customer OJ = new Customer("OJ",OJAddress);

        Product gloves = new Product("Small Black Gloves",12.99,1);
        Product whiteShirt = new Product("Banana Republic Shirt",36.99,2);
        Product car = new Product("Black Getaway Car",70000,1);

        Order order2 = new Order(OJ,new List<Product>(){gloves,whiteShirt,car});

        new List<Order>(){order1,order2}.ForEach(order=>{

            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine($"Total Cost: {order.GetTotalCost()}");
            Console.WriteLine(new string('-',50));
        });
    }
}