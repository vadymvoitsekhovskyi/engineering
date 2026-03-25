namespace factory;

public abstract class Course
{
    public string Title { get; set; }

    // Абстрактний метод, який кожен конкретний курс має реалізувати по-своєму
    public abstract void EnrollStudent(string studentName);
    public abstract void ConductLesson();
}