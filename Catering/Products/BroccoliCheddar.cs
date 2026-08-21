namespace Catering.Products;

public class BroccoliCheddar : Soup
{
    public BroccoliCheddar()
    {
        Name = "BroccoliCheddar";
        Calories = 16;
        CookingDifficulty = CookingDifficulty.Easy;

        Console.WriteLine("Making BroccoliCheddar");
    }
}