namespace Week5;

public class Employee
{
    public int Id { get; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public decimal MonthlySalary { get; set; }
    public string FullName => FirstName + " " + LastName;

    public Employee(int id, string firstName, string lastName, decimal montlySalary)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.MonthlySalary = montlySalary;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Emp Id: {Id}\nEmp Name: {FullName}\nSalary: {MonthlySalary}");
    }
}
