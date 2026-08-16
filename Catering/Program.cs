using Catering.Products;

namespace Catering;

public static class Program
{
    public static void Main(string[] args)
    {
        Americano americano = new Americano();

        Console.WriteLine(americano.Name);
        Console.WriteLine(americano.Calories);
        Console.WriteLine(americano.CookingDifficulty);
        // Americano -> Coffee -> Drink -> Dish -> Object

        BlackTea blackTea = new BlackTea();

        Console.WriteLine(blackTea.Name);
        Console.WriteLine(blackTea.Calories);
        Console.WriteLine(blackTea.CookingDifficulty);


        Cappuccino cappuccino = new Cappuccino();

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
    }
}