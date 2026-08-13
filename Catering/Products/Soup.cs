using System.Globalization;

namespace Catering.Products;

public abstract class Soup : Dish
{
    public string Ingredient { get; protected set; }

    public Soup()
    {
        Console.WriteLine("making soup");
    }
}