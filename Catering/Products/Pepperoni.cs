namespace Catering.Products;

public class Pepperoni : Pizza
{
    public Pepperoni()
    {
        Name = "Pepperoni";
        Calories = 200;
        CookingDifficulty = CookingDifficulty.Medium;

        Console.WriteLine("Making Pepperoni Pizza");
    }
}