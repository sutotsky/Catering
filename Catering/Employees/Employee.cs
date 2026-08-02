using Catering.HR;

namespace Catering.Employees;

public abstract class Employee
{
    public Person Person { get; set; }
    public Guid Id { get; set; }
}