namespace Catering.Products;

public class FruitSalad : Salad
{
    public FruitSalad()
    {
        Name = "Fruit Salad";
        Calories = 0;
        CookingDifficulty = CookingDifficulty.Easy;

        Console.WriteLine("Making Fruit Salad");
    }

}