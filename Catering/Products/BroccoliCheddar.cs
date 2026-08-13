namespace Catering.Products;

public class BroccoliCheddar : Soup
{
    public BroccoliCheddar()
    {
        Name = "Broccoli Cheddar";
        Calories = 50;
        CookingDifficulty = CookingDifficulty.Medium;
        Console.WriteLine("Making Broccoli Cheddar");
    }
}