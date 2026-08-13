namespace Catering.Products;

public abstract class Pasta : Dish
{
    public string NoodleType { get; protected set; }

    public Pasta()
    {
        Console.WriteLine("preparing pasta");
    }

}   