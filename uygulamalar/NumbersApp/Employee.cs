class Employee
{
    // field (alan)
    private String _firstName;

    private String _lastName;
    private Decimal _salary;

    public String LastName
    {
        get { return _lastName.ToUpper(); }
        set { _lastName = value; }
    }



    public String FirstName
    {
        get
        {
            return _firstName.ToUpper();
        }
        set
        {
            _firstName = value;
        }
    }

    public Decimal Salary
    {
        get
        {
            return _salary;
        }
        set
        {
            if (value <28_000m) 
                _salary = 28_000m;
            else _salary = value;
        }
    }



    public Employee()
    {
        System.Console.WriteLine("Yapıcı metot çalıştı.");
    }
}