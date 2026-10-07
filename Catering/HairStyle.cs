namespace Catering;

public class HairStyle
{
    private double _lengthCm;

    public double LengthCm
    {
        get
        {
            return _lengthCm;
        }
        set
        {
            if (value >= 0)
            {
                _lengthCm = value;
            }
        }
    }
    
    public string HairCutStyle { get; private set; }

    public HairStyle(double lengthCm, string hairCutStyle)
    {
        LengthCm = lengthCm;
        HairCutStyle = hairCutStyle;
    }
    
}