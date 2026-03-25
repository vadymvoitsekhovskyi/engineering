namespace factory;

public class OnlineCourse : Course
{
    public override void EnrollStudent(string studentName)
    {
        Console.WriteLine($"[Online] Студент {studentName} отримав посилання на Zoom для курсу '{Title}'.");
    }

    public override void ConductLesson()
    {
        Console.WriteLine($"[Online] Початок трансляції лекції '{Title}' в інтернеті.\n");
    }
}