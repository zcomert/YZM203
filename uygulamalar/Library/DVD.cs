namespace Library;

public class DVD : LibraryItem
{
    public double Duration { get; set; }

    public DVD(int itemId, string title, double duration) : base(itemId, title)
    {
        this.Duration = duration;
    }

    public void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Duration: {Duration}");
    }

    public override decimal CalculateLateFee(int daysOverdue)
    {
        return daysOverdue * 15 + 10;
    }
}
