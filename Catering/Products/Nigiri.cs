namespace Catering.Products;

public class Nigiri : Sushi
{
    public Nigiri()
    {
        Name = "Nigiri Sushi";
        Calories = 50;
        CookingDifficulty = CookingDifficulty.Hard;

        Console.WriteLine("Making Nigiri Sushi");
    }
}