namespace factory;

public abstract class Course
{
    public string Title { get; set; }
    
    public abstract void EnrollStudent(string studentName);
    public abstract void ConductLesson();
}