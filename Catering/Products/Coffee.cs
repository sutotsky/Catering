namespace Catering.Products;

public abstract class Coffee : Drink
{
    public string CoffeeBean { get; protected set; }
    
    public string  BeanTypeQuality { get; protected set; } 

    public Coffee()
    {
        Console.WriteLine("making coffee");
    }
}