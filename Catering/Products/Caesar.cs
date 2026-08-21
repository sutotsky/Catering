namespace Catering.Products;

public class Caesar : Salad
{
    public Caesar()
    {
        Name = "Caesar";
        Calories = 10;
        CookingDifficulty = CookingDifficulty.Easy;

        Console.WriteLine("Making Caesar Salad");
    }
}