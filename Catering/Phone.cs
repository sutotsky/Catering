using System.Globalization;

namespace Catering;

public class Phone
{
    private string _name;
    private string _model;
    private Guid _identifierNumber;
    private Colors colors;
    private int _price;
    
    
    public string Name { get; set; }
    public string Model { get; private set; }
    public Guid Guid { get; set; }
    public Colors Colors = Colors.black;
    public DateTime ProductionYear { get; private set; }

    public int Price
    {
        get
        {
            return (Price);
        }

        set
        {
            if (value >= 10000) ;

            _price = value;
        }
    }

}
