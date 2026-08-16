namespace Catering.Products;

public class Americano : Coffee
{
    public Americano()
    {
        Name = "Americano";
        Calories = 5;
        CookingDifficulty = CookingDifficulty.Easy;
        
        Console.WriteLine("Creating americano");
    }
}