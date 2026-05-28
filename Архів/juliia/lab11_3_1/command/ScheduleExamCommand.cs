namespace command;

public class ScheduleExamCommand : ICommand
{
    private UniversityDatabase _database;
    private string _subject;
    private DateTime _date;

    public ScheduleExamCommand(UniversityDatabase database, string subject, DateTime date)
    {
        _database = database;
        _subject = subject;
        _date = date;
    }

    public void Execute()
    {
        _database.ScheduleExam(_subject, _date);
    }

    public void Undo()
    {
        Console.WriteLine($"[Скасування]: Скасування наказу про призначення іспиту з '{_subject}'.");
        _database.CancelExam(_subject);
    }
}