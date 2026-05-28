namespace composite;

public class Module : CourseComponent
{
    private List<CourseComponent> _components = new List<CourseComponent>();

    public Module(string name) : base(name)
    {
        
    }

    public override void Add(CourseComponent component)
    {
        _components.Add(component);
    }

    public override void Remove(CourseComponent component)
    {
        _components.Remove(component);
    }

    public override void Display(int indent)
    {
        Console.WriteLine(new string('-', indent) + "+ Модуль: " + Name);
        
        foreach (CourseComponent component in _components)
        {
            component.Display(indent + 2);
        }
    }
}