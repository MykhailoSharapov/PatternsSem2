using Lab_5.Handlers;
using Lab_5.Models;
using Lab_5.Repositories;

class Program
{
    static void Main(string[] args)
    {
        User user = new() { Email = "jhon_yick@killer.net", Id = Guid.NewGuid(), Name = "John", Password = "Yick" };

        Product product = new() { Id = Guid.NewGuid(), Name = "Gun", Price = 700 };

        Order order = new Order
        {
            Id = Guid.NewGuid(),
            Products = new List<Product>
            {
                product,
                new Product { Id = Guid.NewGuid(), Name = "Grenade", Price = 400 }
            }
        };

        Handler handler = new UserHandler(new UserRepository());

        var userResponse = handler.Handle(user);
        Console.WriteLine(userResponse);

        handler = new ProductHandler(new ProductRepository());
        var productResponse = handler.Handle(product);
        Console.WriteLine(productResponse);

        handler = new OrderHandler(new OrderRepository());
        var orderResponse = handler.Handle(order);
        Console.WriteLine(orderResponse);
    }
}
