namespace composite;

public abstract class CourseComponent
{
    protected string Name;

    public CourseComponent(string name)
    {
        Name = name;
    }
    
    public abstract void Display(int indent);
    public abstract void Add(CourseComponent component);
    public abstract void Remove(CourseComponent component);
}