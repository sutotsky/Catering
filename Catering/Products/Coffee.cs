namespace Catering.Products;

public abstract class Coffee : Drink
{
    public string CoffeeBean { get; protected set; }
    
    public CoffeeBeanQuality CoffeeBeanQuality { get; protected set; } 

    public Coffee()
    {
        Console.WriteLine("making coffee");
    }
}