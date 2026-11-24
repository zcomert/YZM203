var employess = new Employee[]
{
    new Employee
    {
        FirstName = "Elvan",
        LastName = "Negiş",
        Salary = 75_000m
    },
    new Employee() {FirstName = "Ceren", LastName = "Baş", Salary = 75_000m },
    new Employee()
    {
        FirstName = "Fatih",
        LastName  = "Gülseren",
        Salary = 190_000m
    },
    new Employee()
    {
        FirstName = "Hamza",
        LastName = "Alak",
        Salary = 1_000_000m
    },
    new Employee()
    {
        FirstName = "Kadir",
        LastName = "Çakir",
        Salary = 80_000m
    }
    
};

for (int i = 0; i < employess.Length; i++)
{
    Console.WriteLine($"{employess[i].FirstName,-10} {employess[i].LastName,-10} {employess[i].Salary}");




}

static void NumberAppSample()
{
    // Bir sınıfı nasıl kullanacağız?

    int x = 5; // readonly-struct // value Type

    // class -> Ref Type
    Number number = new Number(); // Yapıcı metot burada çalışır
                                  // Yapıcı metot ile birlikte mantıksal varlık, fiziksel varlığına dönüşür.
                                  // Referans verilir. 

    System.Console.WriteLine($"Max = {number.GetMax()}");
    System.Console.WriteLine($"Min = {number.GetMin()}");
}

static void Employee()
{
    Employee emp1 = new Employee();
    emp1.FirstName = "Mehtap";
    emp1.LastName = "Ay";
    emp1.Salary = 75_000m;

    System.Console.WriteLine($"Adınız: {emp1.FirstName}");
    System.Console.WriteLine($"Soyadınz: {emp1.LastName}");
    System.Console.WriteLine($"Maaş: {emp1.Salary}");

    Employee emp2 = new Employee()
    {
        FirstName = "Arda",
        LastName = "Güler",
        Salary = 3_000_000
    };
}