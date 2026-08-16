namespace Catering.Products;

public class Cappuccino : Coffee
{
    public Cappuccino()
    {
        Name = "Cappuccino";
        Calories = 20;
        CookingDifficulty = CookingDifficulty.Easy;

        Console.WriteLine("Making Cappuccino");
    }
}