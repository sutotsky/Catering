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


        Cheese cheese = new Cheese();

        Console.WriteLine(cheese.Name);
        Console.WriteLine(cheese.Calories);
        Console.WriteLine(cheese.CookingDifficulty);


        BroccoliCheddar broccoliCheddar = new BroccoliCheddar();

        Console.WriteLine(broccoliCheddar.Name);
        Console.WriteLine(broccoliCheddar.Calories);
        Console.WriteLine(broccoliCheddar.CookingDifficulty);

        Caesar caesar = new Caesar();

        Console.WriteLine(caesar.Name);
        Console.WriteLine(caesar.Calories);
        Console.WriteLine(caesar.CookingDifficulty);


        Capellini capellini = new Capellini();

        Console.WriteLine(capellini.Name);
        Console.WriteLine(capellini.Calories);
        Console.WriteLine(capellini.CookingDifficulty);


        Cappuccino cappuccino = new Cappuccino();

        Console.WriteLine(cappuccino.Name);
        Console.WriteLine(cappuccino.Calories);
        Console.WriteLine(cappuccino.CookingDifficulty);
    }
    
    
} 