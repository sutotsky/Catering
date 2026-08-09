using Catering.Products;

namespace Catering;

public static class Program
{
    public static void Main(string[] args)
    {
        Americano americano = new Americano();

        Console.WriteLine(americano.Name);
        // Americano -> Coffee -> Drink -> Dish -> Object
    }
}