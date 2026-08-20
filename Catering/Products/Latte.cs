namespace Catering.Products;

public class Latte : Coffee
{
    public Latte(string coffeeBean, CoffeeBeanQuality coffeeBeanQuality)
    {
        Name = "Latte";
        Calories = 50;
        CookingDifficulty = CookingDifficulty.Medium;
        CoffeeBean = coffeeBean;
        CoffeeBeanQuality = coffeeBeanQuality;

        Console.WriteLine("Making Latte");
    }
}