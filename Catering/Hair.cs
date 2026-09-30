namespace Catering;

public class Hair
{
    public int Height;
    public string HairCutStyle;

    public Hair(int height, string hairCutStyle)
    {
        Height = height;
        HairCutStyle = hairCutStyle;
    }

    public void CutHair(int hairCut, string hairCutStyle)
    {
        if (hairCut >= Height)
        {
            Console.WriteLine("Give me a haircut");
        }
            
    }
}