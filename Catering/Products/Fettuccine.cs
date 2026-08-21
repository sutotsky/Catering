namespace Catering.Products;

public class Fettuccine : Pasta
{
    public Fettuccine()
    {
        Name = "Fettuccine Pasta";
        Calories = 250;
        CookingDifficulty = CookingDifficulty.Medium;

        Console.WriteLine("Making Fettuccine Pasta");
    }
}