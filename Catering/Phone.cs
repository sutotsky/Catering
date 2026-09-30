using System.Drawing;
using System.Globalization;

namespace Catering;

public class Phone
{
    
    private double _price;
    
    public double Price
    {
        get { return _price; }
        set
        {
            if (value >= 0)
            {
                _price = value;
            }
        }
    }
    
    public Guid Id { get; private set; }
    public string Brand { get; private set; }
    public string Model { get; private set; }
    public string Color { get; private set; }
    public int ProductionYear { get; private set; }

    public Phone(string brand, string model, string color, int productionYear)
    {
        Id = Guid.NewGuid();
        Brand = brand;
        Model = model;
        Color = color;
        
        if (productionYear >= 0)
        {
            ProductionYear = productionYear;
        }
    }
    
}
