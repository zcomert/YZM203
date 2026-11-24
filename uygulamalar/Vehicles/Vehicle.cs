namespace Vehicles;

// ARAÇ
public class Vehicle
{
    public int Id { get; }
    public string Model { get; set; }
    public string Color { get; set; }
    public DateOnly ManufactorDate { get; set; }
    public string FuelType { get; set; }
    public bool EngineStatus { get; set; } = false;

    public Vehicle(int id)
    {
        Id = id;
    }

    public Vehicle(int id, string model, string color, DateOnly manufactorDate, string fuelType)
    : this(id)
    {
        Model = model;
        Color = color;
        ManufactorDate = manufactorDate;
        FuelType = fuelType;
    }

    public void ToggleEngine()
    {
        EngineStatus = EngineStatus != true ? true : false;
    }

    public void Display()
    {
        Console.WriteLine($"Id: {Id}\nModel: {Model}\nRenk: {Color}\n"
        + $"Üretim Tarihi: {ManufactorDate}\nYakit Tipi: {FuelType}\n"
        + $"Motor Durumu: {EngineStatus}");
    }
}