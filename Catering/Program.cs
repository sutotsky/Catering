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


        Espresso espresso = new Espresso("Ethiopia", CoffeeBeanQuality.Medium);

        Console.WriteLine(espresso.CoffeeBean);
        Console.WriteLine(espresso.CoffeeBeanQuality);
        Console.WriteLine(espresso.Name);
        Console.WriteLine(espresso.Calories);
        Console.WriteLine(espresso.CookingDifficulty);


        BroccoliCheddar broccoliCheddar = new BroccoliCheddar();

        Console.WriteLine(broccoliCheddar.Name);
        Console.WriteLine(broccoliCheddar.Calories);
        Console.WriteLine(broccoliCheddar.CookingDifficulty);

        Greek greek = new Greek();

        Console.WriteLine(greek.Name);
        Console.WriteLine(greek.Calories);
        Console.WriteLine(greek.CookingDifficulty);


        Capellini capellini = new Capellini();

        Console.WriteLine(capellini.Name);
        Console.WriteLine(capellini.Calories);
        Console.WriteLine(capellini.CookingDifficulty);


        Caprese caprese = new Caprese();

        Console.WriteLine(caprese.Name);
        Console.WriteLine(caprese.Calories);
        Console.WriteLine(caprese.CookingDifficulty);


        Cheese cheese = new Cheese();

        Console.WriteLine(cheese.Name);
        Console.WriteLine(cheese.Calories);
        Console.WriteLine(cheese.CookingDifficulty);


        Fettuccine fettuccine = new Fettuccine();

        Console.WriteLine(fettuccine.Name);
        Console.WriteLine(fettuccine.Calories);
        Console.WriteLine(fettuccine.CookingDifficulty);


        FruitSalad fruitSalad = new FruitSalad();

        Console.WriteLine(fruitSalad.Name);
        Console.WriteLine(fruitSalad.Calories);
        Console.WriteLine(fruitSalad.CookingDifficulty);

        GreenTea greenTea = new GreenTea();

        Console.WriteLine(greenTea.Name);
        Console.WriteLine(greenTea.Calories);
        Console.WriteLine(greenTea.CookingDifficulty);


        Hawaiian hawaiian = new Hawaiian();

        Console.WriteLine(hawaiian.Name);
        Console.WriteLine(hawaiian.Calories);
        Console.WriteLine(hawaiian.CookingDifficulty);


        Linguine linguine = new Linguine();

        Console.WriteLine(linguine.Name);
        Console.WriteLine(linguine.Calories);
        Console.WriteLine(linguine.CookingDifficulty);


        Margharita margharita = new Margharita();

        Console.WriteLine(margharita.Name);
        Console.WriteLine(margharita.Calories);
        Console.WriteLine(margharita.CookingDifficulty);


        NegitoraMaki negitoraMaki = new NegitoraMaki();

        Console.WriteLine(negitoraMaki.Name);
        Console.WriteLine(negitoraMaki.Calories);
        Console.WriteLine(negitoraMaki.CookingDifficulty);


        Nigiri nigiri = new Nigiri();

        Console.WriteLine(nigiri.Name);
        Console.WriteLine(nigiri.Calories);
        Console.WriteLine(nigiri.CookingDifficulty);


        Spaghetti spaghetti = new Spaghetti();

        Console.WriteLine(spaghetti.Name);
        Console.WriteLine(spaghetti.Calories);
        Console.WriteLine(spaghetti.CookingDifficulty);

        Temaki temaki = new Temaki();

        Console.WriteLine(temaki.Name);
        Console.WriteLine(temaki.Calories);
        Console.WriteLine(temaki.CookingDifficulty);
    }
}