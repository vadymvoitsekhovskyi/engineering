namespace command;

public class UniversityDatabase
{
    private List<string> students = new List<string>();

    public void AddStudent(string studentName, string faculty)
    {
        students.Add(studentName);
        Console.WriteLine($"[База даних]: Студента {studentName} зараховано на факультет '{faculty}'.");
    }

    public void RemoveStudent(string studentName)
    {
        if (students.Contains(studentName))
        {
            students.Remove(studentName);
            Console.WriteLine($"[База даних]: Студента {studentName} відраховано з університету.");
        }
        else
        {
            Console.WriteLine($"[База даних]: Помилка. Студента {studentName} не знайдено.");
        }
    }

    public void ScheduleExam(string subject, DateTime date)
    {
        Console.WriteLine($"[База даних]: Призначено іспит з предмету '{subject}' на {date.ToShortDateString()}.");
    }

    public void CancelExam(string subject)
    {
        Console.WriteLine($"[База даних]: Іспит з предмету '{subject}' скасовано.");
    }
}