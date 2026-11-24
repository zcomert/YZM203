class Employee : IComparable
{
    public int Id { get; set; }
    public String FullName { get; set; } = String.Empty;
    public Decimal Salary { get; set; }
    public Employee()
    {
        // referans veriyor -> null
    }

    public int CompareTo(object? obj)
    {
        if (obj is Employee)
        {
            var temp = (Employee)obj;
            return Salary.CompareTo(temp?.Salary);
        }
        // if(this.Salary>temp.Salary)
        //     return 1;
        // else if(this.Salary.Equals(temp.Salary))
        //     return 0;
        // else
        //     return -1;
        throw new Exception("Karşılaştırma yapılamadı.");
    }

    public override string ToString()
    {
        return $"{Id} {FullName}, {Salary}";
    }
}