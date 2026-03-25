namespace factory;

public class OfflineCourse : Course
{
    public override void EnrollStudent(string studentName)
    {
        Console.WriteLine($"[Offline] Студент {studentName} записаний у групу. Видано перепустку в аудиторію для курсу '{Title}'.");
    }

    public override void ConductLesson()
    {
        Console.WriteLine($"[Offline] Студенти зібралися в аудиторії. Лектор починає заняття '{Title}' біля дошки...\n");
    }
}