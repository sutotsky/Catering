namespace Catering;

public class Dish
{
    private string name;
    private string taste;
    private int quantity;

    public string Taste
    {
        get { return taste;}
        set { taste = value; }
    }

    public int Quantity
    {
        get {return quantity; }
        set {quantity = value;}
   }    
   

    public string Name
    {
        get {return name;}
        set{name = value;}
    }
 
}