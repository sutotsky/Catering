namespace Catering.Products;

public class GreenTea : Tea
{
    public GreenTea()
    {
        Name = "Green Tea";
        Calories = 0;
        CookingDifficulty = CookingDifficulty.Easy;

        Console.WriteLine("Making Green Tea");
    }
}