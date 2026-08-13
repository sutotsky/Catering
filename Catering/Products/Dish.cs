namespace Catering.Products;

public abstract class Dish
{
    
    public string Name { get; protected set; }
    public int Calories { get; set; }
    public CookingDifficulty CookingDifficulty { get; set; }

    public Dish()
    {
        Console.WriteLine("Creating dish");
    }
    
}