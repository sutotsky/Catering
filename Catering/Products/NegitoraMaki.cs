namespace Catering.Products;

public class NegitoraMaki : Sushi
{
    public NegitoraMaki()
    {
        Name = "NegitoraMaki";
        Calories = 150;
        CookingDifficulty = CookingDifficulty.Easy;

        Console.WriteLine("Making NegitoraMaki");
    }
}