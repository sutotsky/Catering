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

        BarberShop barberShop = new BarberShop();
        Hair hair = new Hair(5, "Faid");

        Console.WriteLine(hair.Height);
        Console.WriteLine(hair.HairCutStyle);
        Console.WriteLine(barberShop.Haircut);
    }
}