namespace Catering.Products;

public class BlackTea : Tea
{
    public BlackTea()
    {
        Name = "Black Tea";
        Calories = 0;
        CookingDifficulty = CookingDifficulty.Easy;
        
        Console.WriteLine("Making Black Tea");
    }
}