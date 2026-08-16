using Catering.Products;

namespace Catering;

public static class Program
{
    public static void Main(string[] args)
    {
        Americano americano = new Americano("Nigeria", CoffeeBeanQuality.High);

        Console.WriteLine(americano.Name);
        Console.WriteLine(americano.Calories);
        Console.WriteLine(americano.CookingDifficulty);
        // Americano -> Coffee -> Drink -> Dish -> Object

        BlackTea blackTea = new BlackTea();

        Console.WriteLine(blackTea.Name);
        Console.WriteLine(blackTea.Calories);
        Console.WriteLine(blackTea.CookingDifficulty);


        Cappuccino cappuccino = new Cappuccino("Ghana", CoffeeBeanQuality.High);

        Console.WriteLine(cappuccino.Name);
        Console.WriteLine(cappuccino.Calories);
        Console.WriteLine(cappuccino.CookingDifficulty);


        Pepperoni pepperoni = new Pepperoni();

        Console.WriteLine(pepperoni.Name);
        Console.WriteLine(pepperoni.Calories);
        Console.WriteLine(pepperoni.CookingDifficulty);


        ChickenNoodle chickenNoodle = new ChickenNoodle();

        Console.WriteLine(chickenNoodle.Name);
        Console.WriteLine(chickenNoodle.Calories);
        Console.WriteLine(chickenNoodle.CookingDifficulty);


        Caesar caesar = new Caesar();

        Console.WriteLine(caesar.Name);
        Console.WriteLine(caesar.Calories);
        Console.WriteLine(caesar.CookingDifficulty);


        EggDrop eggDrop = new EggDrop();

        Console.WriteLine(eggDrop.Name);
        Console.WriteLine(eggDrop.Calories);
        Console.WriteLine(eggDrop.CookingDifficulty);

        Americano americano1 = new Americano("Brazilian", CoffeeBeanQuality.Medium);

        Console.WriteLine(americano1.CoffeeBean);
        Console.WriteLine(americano1.CoffeeBeanQuality);

        Americano americano2 = new Americano("Kenya", CoffeeBeanQuality.High);

        Console.WriteLine(americano2.CoffeeBean);
        Console.WriteLine(americano2.CoffeeBeanQuality);
    }
}