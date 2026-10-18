namespace Catering;

public class BarberShop
{
    
    public string Name { get; set; }
    public string Address { get; set; }
    
    public void ApplyHairCut(Person client, HairStyle hairStyle)
    {
        if (client.HairLengthCm > hairStyle.LengthCm)
        {
            client.HairLengthCm = hairStyle.LengthCm;

            Console.WriteLine("Applying haircut");
        }
        else
        {
            Console.WriteLine("Your request can't be met");
        }
    }

    public void EditNumber(int number)
    {
        number = 10;
    }
    
}