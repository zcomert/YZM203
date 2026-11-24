class Student : IComparable
{
    public int Id { get; set; } 
    public String FullName {get; set;} = String.Empty;
    public int Age { get; set; }
    public decimal GPA { get; set; }

    public int CompareTo(object? other)
    {
        if(other is Student)
        {
            Student temp = (Student)other;
            return this.GPA.CompareTo(temp.GPA);
        }
        return 0;
    //    if(this.GPA>temp.GPA)
    //     return 1;
    //    else if(this.GPA==temp.GPA)
    //    return 0;
    //    else
    //    return -1;
    }
}