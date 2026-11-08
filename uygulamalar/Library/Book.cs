namespace Library;

public class Book : LibraryItem
{
    private string Author { get; set; }

    public Book(int itemId, string title, string author) : base(itemId, title)
    {
        this.Author = author;
    }

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Author: {Author}");
    }

    public override decimal CalculateLateFee(int daysOverdue)
    => daysOverdue * 10;
}
