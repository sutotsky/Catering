namespace Catering.Products;

public class Cheese : Pizza
{
    public Cheese()
    {
        Name = "Cheese Pizza";
        Calories = 150;
        CookingDifficulty = CookingDifficulty.Medium;
        Console.WriteLine("Making Cheese Pizza");
    }
}