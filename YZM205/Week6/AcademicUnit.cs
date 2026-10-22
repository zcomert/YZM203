namespace Week6;

public class AcademicUnit : UniversityUnit
{
    protected int StudentCount { get; set; }
    protected decimal ResearchBudget { get; set; }

    public AcademicUnit(int unitId, string? unitName, int staffCount, decimal annualCostPerStaff,
    int studentCount, decimal researchBudget)
    : base(unitId, unitName, staffCount, annualCostPerStaff)
    {
        StudentCount = studentCount;
        ResearchBudget = researchBudget;
    }

    protected override decimal CalculateAnnualBudget()
    {
        return CalculateAnnualPersonelCost() + ResearchBudget + StudentCount * 10000;
    }

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Student Count: {StudentCount}\nResearch Budget: {ResearchBudget}\n" + 
        $"Annual Budget: {CalculateAnnualBudget()}");
    }
}
