namespace Catering.Products;

public abstract class Dish
{
    
    public string Name { get; protected set; }
    public int Calories { get; protected set; }
    public CookingDifficulty CookingDifficulty { get; protected set; }

    public Dish()
    {
        Console.WriteLine("Creating dish");
    }
    
}