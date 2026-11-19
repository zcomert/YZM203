using Week9;

public class Program
{
    public static void Main(string[] args)
    {
        CourseCatalog catalog = new CourseCatalog();
        catalog.AddCourse(new Course("YZM101", "Programlamaya Giriş I", 6));
        catalog.AddCourse(new Course("YZM205", "Nesne Yönelimli Programlama Lab.", 6));
        catalog.AddCourse(new Course("YZM203", "Nesne Yönelimli Programlama", 6));

        System.Console.WriteLine("Unsorted List:");
        foreach (var item in catalog)
        {
            Console.WriteLine(item.ToString());
        }

        catalog.Sort();
        System.Console.WriteLine("Sorted List:");
        foreach (var item in catalog)
        {
            Console.WriteLine(item.ToString());
        }
    }
}