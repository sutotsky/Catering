namespace Catering.Products;

public class Spaghetti : Pasta
{
    public Spaghetti()
    {
        Name = "Spaghetti";
        Calories = 250;
        CookingDifficulty = CookingDifficulty.Easy;

        Console.WriteLine("Making Spaghetti pasta");
    }
}