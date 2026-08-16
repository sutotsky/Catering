namespace Catering.Products;

public class Americano : Coffee
{
    public Americano(string coffeeBean, CoffeeBeanQuality coffeeBeanQuality)
    {
        Name = "Americano";
        Calories = 5;
        CookingDifficulty = CookingDifficulty.Easy;
        CoffeeBean = coffeeBean;
        CoffeeBeanQuality = coffeeBeanQuality;
        
        Console.WriteLine("Creating americano");
    }
}