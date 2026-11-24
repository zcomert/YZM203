namespace Week5;

public class Program
{
    public static void Main(string[] args)
    {
        Employee[] employees = 
        {
            new Employee(1, "Mehmet", "Alp", 55000),
            new Developer(2, "Alper", "Kor", 75000, "C#"),
            new Developer(3, "Mustafa", "Gök", 95000, "Java"),
            new Manager(5, "Kemal", "Dag", 100000, 5)
        };

        foreach (var emp in employees)
        {
            emp.DisplayInfo();
        }
        // Developer dev3 = (Developer) new Employee(4, "Namık", "Mehmet", 60000);
        // dev3.DisplayInfo();
    }
}