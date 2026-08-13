namespace Catering.Products;

public class Cappuccino : Coffee
{
    public Cappuccino()
    {
        Name = "Cappuccino";
        Calories = 4;
        CookingDifficulty = CookingDifficulty.Medium;

        Console.WriteLine("Making Cappuccino");
    }
}