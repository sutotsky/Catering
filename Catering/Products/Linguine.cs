namespace Catering.Products;

public class Linguine : Pasta
{
    public Linguine()
    {
        Name = "Linguine";
        Calories = 350;
        CookingDifficulty = CookingDifficulty.Medium;

        Console.WriteLine("Making Linguine Pasta");
    }
}