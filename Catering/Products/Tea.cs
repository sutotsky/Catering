namespace Catering.Products;

public abstract class Tea : Drink
{
    public string FreshLeave { get; protected set; }

    public Tea()
    {
        Console.WriteLine("Making Tea");
    }
}