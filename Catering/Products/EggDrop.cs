namespace Catering.Products;

public class EggDrop : Soup
{
    public EggDrop()
    {
        Name = "EggDrop";
        Calories = 300;
        CookingDifficulty = CookingDifficulty.Hard;

        Console.WriteLine("Making EggDrop Soup");
    }
}