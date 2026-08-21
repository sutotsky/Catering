namespace Catering.Products;

public class Espresso : Coffee
{
    public Espresso(string coffeebean, CoffeeBeanQuality coffeeBeanQuality)
    {
        Name = "Espresso";
        Calories = 30;
        CookingDifficulty = CookingDifficulty.Easy;
        CoffeeBean = coffeebean;
        CoffeeBeanQuality = coffeeBeanQuality;

        Console.WriteLine("Making Espresso");

    }
}