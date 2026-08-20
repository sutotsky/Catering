namespace Catering.Products;

public class Hawaiian : Pizza
{
    public Hawaiian()
    {
        Name = "Hawaiian Pizza";
        Calories = 450;
        CookingDifficulty = CookingDifficulty.Medium;

        Console.WriteLine("Making Hawaiian Pizza");
    }
}