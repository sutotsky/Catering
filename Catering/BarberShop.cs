namespace Catering;

public class BarberShop
{
    public string Name { get; set; }
    public string Address { get; set; }
    public void ApplyHairCut(Person client, HairStyle hairStyle)
    {
        Console.WriteLine("ApplyHaitcut");
    }
    
}   