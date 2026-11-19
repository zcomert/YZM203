namespace Week9;

public class Course : IComparable<Course>
{
    public string CourseCode { get; }
    public string CourseName { get; }
    public int Credits { get; }

    public Course(string courseCode, string courseName, int credits)
    {
        CourseCode = courseCode;
        CourseName = courseName;
        Credits = credits;
    }

    public override string ToString()
    {
        return $"{CourseCode} - {CourseName} - {Credits}";
    }

    public int CompareTo(Course? other)
    {
        return CourseCode.CompareTo(other.CourseCode);
        // return other.CourseCode.CompareTo(CourseCode);
    }
}
