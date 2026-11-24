using System.Collections;

namespace Week9;

public class CourseCatalog : IEnumerable<Course>
{
    private List<Course> courses;

    public int Count => courses.Count();

    public CourseCatalog()
    {
        courses = new List<Course>();
    }

    public void AddCourse(Course course)
    {
        courses.Add(course);
    }

    public void Sort()
    {   
        courses.Sort();
    }

    public IEnumerator<Course> GetEnumerator()
    {
        return courses.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
