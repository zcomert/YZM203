// Built-in inteface

var numbers = new NumberManager(10, 20, 30, 40);

numbers.Add(90);
numbers.Add(80);
numbers.Add(70);
numbers.Add(60);
numbers.Add(50);


foreach (var item in numbers)
{
    System.Console.WriteLine(item);
}



static void BuiltInIntefaceSample()
{
    int a = 25; // erzurum 
    int b = 14; // bolu
    System.Console.WriteLine(a.CompareTo(b));
    if (a > b)
    {
        System.Console.WriteLine("a daha büyük!");
    }
    else
    {
        System.Console.WriteLine("b daha büyük!");
    }

    var std1 = new Student()
    {
        Id = 1,
        FullName = "Eray Ağar",
        Age = 22,
        GPA = 3.70m
    };

    var std2 = new Student();
    std2.Id = 2;
    std2.FullName = "Mustafa Aydemir";
    std2.Age = 23;
    std2.GPA = 3.54m;

    if (std1.CompareTo(std2) > 0)
    {
        System.Console.WriteLine($"{std1.FullName} büyüktür {std2.FullName}");
    }
    else
    {
        System.Console.WriteLine($"{std1.FullName} küçüktür {std2.FullName}");
    }
}
