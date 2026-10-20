namespace Library;

public abstract class LibraryItem
{
    protected int ItemId { get; set; }
    protected string Title { get; set; }

    public LibraryItem(int itemId, string title)
    {
        this.ItemId = itemId;
        this.Title = title;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Id: {ItemId}\nTitle: {Title}");
    }

    public abstract decimal CalculateLateFee(int daysOverdue);
}