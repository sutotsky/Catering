using Catering.HR;

namespace Catering;

public static class Program
{
    public static void Main(string[] args)
    {
        
        BarberShop barberShop = new BarberShop();
        Person person = new Person();
        HairStyle hairStyle = new HairStyle(3.5,"Fade");
        
        Console.WriteLine(barberShop.ApplyHairCut);
        Console.WriteLine(person.HairLengthCm);
        Console.WriteLine(hairStyle.HairCutStyle);
        Console.WriteLine("Give haircut to"  +  "client"  +  "hairstyle");
        
    }
}