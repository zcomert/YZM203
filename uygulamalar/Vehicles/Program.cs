namespace Vehicles
{

    public partial class Program
    {
        public static void Main(string[] args)
        {
            // Nesne
            Vehicle vehicle1 = new Vehicle(1,
            "Renault",
            "Kirmizi",
            DateOnly.Parse("2026-05-15"),
            "Benzinli");
            // Nesne Metotları
            vehicle1.ToggleEngine();
            vehicle1.Display();

            Car car1 = new Car(2,
            "BMW",
            "Mavi",
            DateOnly.Parse("2025-10-10"),
            "Dizel",
            "Sedan",
            4,
            3,
            2);
            car1.ToggleEngine();
            car1.Display();
        }
    }
}