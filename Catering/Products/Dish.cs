namespace Catering.Products;

public abstract class Dish
{
    public string Name { get; set; }
    public int Calories { get; set; }
    public CookingDifficulty CookingDifficulty { get; set; }
}