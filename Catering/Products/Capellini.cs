namespace Catering.Products;

public class Capellini : Pasta
{
    public Capellini()
    {
        Name = "Capellini";
        Calories = 350;
        CookingDifficulty = CookingDifficulty.Medium;

        Console.WriteLine("Making Capellini Pasta");
    }
}