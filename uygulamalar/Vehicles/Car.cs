namespace Vehicles
{
    public class Car : Vehicle
    {
        public string CarType { get; set; }
        public int NumberOfWheels { get; set; } = 4;
        public int NumberOfDoors { get; set; } = 3;
        public int NumberOfSeats { get; set; }

        public Car(int id, string model, string color, DateOnly manufactorDate, string fuelType,
        string carType, int numberOfWheels, int numberOfDoors, int numberOfSeats)
        : base(id, model, color, manufactorDate, fuelType)
        {
            CarType = carType;
            NumberOfWheels = numberOfWheels;
            NumberOfDoors = numberOfDoors;
            NumberOfSeats = numberOfSeats;
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine($"Araç Türü: {CarType}\nLastik Sayisi: {NumberOfWheels}\n" +
            $"Koltuk Sayisi: {NumberOfSeats}\nKapi Sayisi: {NumberOfDoors}");
        }
    }
}