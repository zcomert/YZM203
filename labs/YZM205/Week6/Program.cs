namespace Week6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AcademicUnit unit1 = new AcademicUnit(1002, "Tübitak1002", 5, 25000, 5, 150000);
            unit1.DisplayInfo();

            AdministrativeUnit unit2 = new AdministrativeUnit(111, "Bilgi İslem Daire Baskanligi", 10, 15000, 5);
            unit2.DisplayInfo();
        }
    }
}