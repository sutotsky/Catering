using System.Security.Cryptography.X509Certificates;

namespace Catering;

public class Person
{
    private int _age;
    public string Name { get; set; }
    public Sex Sex { get; set; }

    private double _hairLengthCm;

    public double HairLengthCm
    {
        get
        {
            return _hairLengthCm;
        }
        set
        {
            if (value >= 0)
            {
                _hairLengthCm = value;
            }
        }
    }

    public int Age
    {
        get
        {
            return _age;
        }
        set
        {
            if (value >= 0)
            {
                _age = value;
            }
        }
    }
}

   
