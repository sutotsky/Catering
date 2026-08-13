namespace Catering.Products;

public abstract class Coffee : Drink
{
    public string CoffeeBean { get; set; }

    public Coffee()
    {
        Console.WriteLine("Creating coffee");
    }
}