namespace Catering.Products;

public class Cappuccino : Coffee
{
    public Cappuccino(string coffeeBean, CoffeeBeanQuality coffeeBeanQuality)
    {
        Name = "Cappuccino";
        Calories = 20;
        CookingDifficulty = CookingDifficulty.Easy;
        CoffeeBean = coffeeBean;
        CoffeeBeanQuality = coffeeBeanQuality;

        Console.WriteLine("Making Cappuccino");
    }
}