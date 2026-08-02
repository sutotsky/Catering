namespace Catering;

public class Passport
{
    public int Series { get; set; }
    public int Number { get; set; }
    public string Issuer { get; set; }
    public DateTime IssueDate { get; set; }
    public string SubDivisionCode { get; set; }
    public DateTime BirthDate { get; set; }
    public string PlaceOfBirth { get; set; }
    
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public Address Address { get; set; }
    
    public Sex Sex { get; set; }
}