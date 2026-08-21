namespace Catering.Products;

public class Temaki : Sushi
{
    public Temaki()
    {
        Name = "Temaki Sushi";
        Calories = 150;
        CookingDifficulty = CookingDifficulty.Hard;

        Console.WriteLine("Making Temaki Sushi");
    }
}