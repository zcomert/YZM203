namespace Week5;

public class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }="";

    public Developer(int id, string firstName, string lastName, decimal monthlySalary)
    : base(id, firstName, lastName, monthlySalary) // super
    {

    }

    public Developer(int id, string firstName, string lastName, decimal monthlySalary,
    string programmingLanguage)
    : this(id, firstName, lastName, monthlySalary)
    {
        this.ProgrammingLanguage = programmingLanguage;
    }

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Language: {ProgrammingLanguage}");
    }
}