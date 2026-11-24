int a = 65;
int b = 5;

if (a.CompareTo(b) > 0)
{
    System.Console.WriteLine($"{a}>{b}");
}
else
{
    System.Console.WriteLine($"{b}");
}

var emp1 = new Employee()
{
    Id = 1,
    FullName = "Ceren Baş",
    Salary = 70_000m
};

Employee emp2 = new Employee();
emp2.Id = 20;
emp2.FullName = "Utku Akar";
emp2.Salary = 55_000m;

if (emp1.CompareTo(emp2) > 0)
{
    System.Console.WriteLine($"{emp1} > {emp2}");
}
