namespace Catering.Products;

public class Americano : Coffee
{
    public Americano()
    {
        Name = "Americano";
        Calories = 15;
        CookingDifficulty = CookingDifficulty.Easy;
        Console.WriteLine("Creating americano");
        

    }
}