namespace Week6;

public class AdministrativeUnit : UniversityUnit
{
    public int ServiceCount { get; set; }
    public AdministrativeUnit(int unitId, string? unitName, int staffCount,
    decimal annualCostPerStaff, int serviceCount)
    : base(unitId, unitName, staffCount, annualCostPerStaff)
    {
        ServiceCount = serviceCount;
    }

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Service Count: {ServiceCount}\nBudget: {CalculateAnnualBudget()}");
    }

    protected override decimal CalculateAnnualBudget()
    => CalculateAnnualPersonelCost() + ServiceCount * 30000;
}
