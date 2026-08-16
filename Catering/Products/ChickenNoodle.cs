namespace Catering.Products;

public class ChickenNoodle : Soup
{
    public ChickenNoodle()
    {
        Name = "Chicken Noodle";
        Calories = 300;
        CookingDifficulty = CookingDifficulty.Medium;

        Console.WriteLine("Making Chicken Noodle Pasta");
    }
}