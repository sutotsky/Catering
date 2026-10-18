namespace Catering;

public static class Program
{
    public static void Main(string[] args)
    {
        Teacher teacher = new Teacher(50, "Andrey", Sex.Male);
        Person student = new Person();

        student.Age = 10;
        
        Console.WriteLine(student.Age);
        teacher.Method1(student);
        Console.WriteLine(student.Age);
    }
}