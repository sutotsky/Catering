using System.Security.Cryptography.X509Certificates;

namespace Catering;

public class Person
{
    private int _age;
    public string Name { get; set; }
    public Sex Sex { get; set; }

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

   
