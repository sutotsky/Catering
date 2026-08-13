namespace Catering.Products;

public class Caesar : Salad
{
    public Caesar()
    {
        Name = "Caesar";
        Calories = 5;
        CookingDifficulty = CookingDifficulty.Easy;
        Console.WriteLine("Making Caesar salad");
    }
}