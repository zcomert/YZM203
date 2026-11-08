namespace Library
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Book item = new Book(1, "C# Programming", "Ali Kod");
            item.DisplayInfo();
            Console.WriteLine($"Fee: {item.CalculateLateFee(5)}");

            DVD item2 = new DVD(2, "Titanic", 120.5);
            item2.Duration = 135.5;
            item2.DisplayInfo();
            Console.WriteLine($"Fee: {item2.CalculateLateFee(5)}");
        }
    }
}