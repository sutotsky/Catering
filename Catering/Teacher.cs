namespace Catering;

public class Teacher
{
    public int Age { get; set; }
    public string Name { get; set; }
    public Sex Sex { get; set; }

    public Teacher(int age, string name, Sex sex)
    {
        Age = age;
        Name = name;
        Sex = sex;
    }

    public void Method1(Person client)
    {
        client.Age = 30;
    }

    public void Method2(Int64 value)
    {
        value = 120000;
    }
}