using Catering.Products;

namespace Catering;

public static class Program
{
    public static void Main(string[] args)
    {
        Phone phone = new Phone("Samsung", "Galaxy S26 Ultra", "black", 2020);

        Console.WriteLine(phone.Id);
        Console.WriteLine(phone.Brand);
        Console.WriteLine(phone.Price);
        Console.WriteLine(phone.ProductionYear);
    }
}