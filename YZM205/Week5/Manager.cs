namespace Week5;

public class Manager : Employee
{
    public int TeamSize { get; set; }

    public Manager(int id, string firstName, string lastName, decimal monthlySalary,
    int teamSize)
    : base(id, firstName, lastName, monthlySalary)
    {
        this.TeamSize = teamSize;
    }

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Team Size: {TeamSize}");
    }
}
