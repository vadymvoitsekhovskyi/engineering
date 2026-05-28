namespace composite;

public class Lesson : CourseComponent
{
    public Lesson(string name) : base(name)
    {
        
    }

    public override void Display(int indent)
    {
        Console.WriteLine(new string('-', indent) + " Урок: " + Name);
    }

    public override void Add(CourseComponent component)
    {
        throw new InvalidOperationException("Помилка. Не можна додати підкомпонент до окремого уроку.");
    }

    public override void Remove(CourseComponent component)
    {
        throw new InvalidOperationException("Помилка. Не можна видалити підкомпонент з окремого уроку.");
    }
}