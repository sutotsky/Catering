namespace Catering.Products;

public class Capellini : Pasta
{
    public Capellini()
    {
        Name = "Capellini Pasta";
        Calories = 45;
        CookingDifficulty = CookingDifficulty.Medium;

        Console.WriteLine("Making Capellini Pasta");
    }
}