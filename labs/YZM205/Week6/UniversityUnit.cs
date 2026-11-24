namespace Week6;

public abstract class UniversityUnit
{
    // Field
    private decimal _annualCostPerStaff;


    // Property
    protected int UnitId { get; }
    protected string? UnitName { get; set; }
    protected int StaffCount { get; set; }

    // Full Property
    protected decimal AnnualCostPerStaff
    {
        get { return _annualCostPerStaff; }
        set
        {
            _annualCostPerStaff = value < 0 ? throw new Exception("Value must be positif!") : value;
        }
        /*
        if (value < 0)
            _annualCostPerStaff = 0;
        else
            _annualCostPerStaff = value;
        */
    }

    protected UniversityUnit(int unitId, string? unitName, int staffCount, decimal annualCostPerStaff)
    {
        UnitId = unitId;
        UnitName = unitName;
        StaffCount = staffCount;
        AnnualCostPerStaff = annualCostPerStaff;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Id: {UnitId}\nName: {UnitName}\nStaff Count: {StaffCount}\n" +
        $"Staff Cost: {AnnualCostPerStaff}");
    }

    protected decimal CalculateAnnualPersonelCost() => StaffCount * AnnualCostPerStaff;

    protected abstract decimal CalculateAnnualBudget();
}
