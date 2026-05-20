namespace command;

public class EnrollStudentCommand : ICommand
{
    private UniversityDatabase _database;
    private string _studentName;
    private string _faculty;

    public EnrollStudentCommand(UniversityDatabase database, string studentName, string faculty)
    {
        _database = database;
        _studentName = studentName;
        _faculty = faculty;
    }

    public void Execute()
    {
        _database.AddStudent(_studentName, _faculty);
    }

    public void Undo()
    {
        Console.WriteLine($"[Скасування]: Скасування наказу про зарахування {_studentName}.");
        _database.RemoveStudent(_studentName);
    }
}