namespace Catering.Products;

public class Margharita : Pizza
{
    public Margharita()
    {
        Name = "Margharita";
        Calories = 450;
        CookingDifficulty = CookingDifficulty.Easy;

        Console.WriteLine("Making Margharita Pizza");
    }
}