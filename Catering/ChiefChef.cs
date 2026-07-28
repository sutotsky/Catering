namespace Catering;

public class ChiefChef: Chef
{
    public string ControlTheActivityOfOtherChefs { get; set; }
    public string MainChef { get; set; }
    public Chef CookInKichen { get; set; }
}