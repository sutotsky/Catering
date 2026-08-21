namespace Catering.Products;

public class Greek : Salad
{
    public Greek()
    {
        Name = "Greek Salad";
        Calories = 35;
        CookingDifficulty = CookingDifficulty.Easy;

        Console.WriteLine("Making Greek Salad");
    }
}