namespace Catering;

public class BarberShop
{
    public int _hairCut;
    
    public int Haircut
    {
        get
        {
            return _hairCut;
        }
        set
        {
            if (value >= 3)
            {
                _hairCut = value;
            }
                
        }
    }
    
}   