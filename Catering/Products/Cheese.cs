namespace Catering.Products;

public class Cheese : Pizza
{
    public Cheese()
    {
        Name = "Cheese Pizza";
        Calories = 400;
        CookingDifficulty = CookingDifficulty.Easy;

        Console.WriteLine("Making Cheese Pizza");
    }
}