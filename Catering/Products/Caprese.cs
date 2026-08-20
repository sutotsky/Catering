namespace Catering.Products;

public class Caprese : Salad
{
    public Caprese()
    {
        Name = "Caprese";
        Calories = 30;
        CookingDifficulty = CookingDifficulty.Medium;

        Console.WriteLine("Making Caprese Salad");
    }
}