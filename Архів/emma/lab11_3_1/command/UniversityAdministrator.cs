namespace command;

public class UniversityAdministrator
{
    private Stack<ICommand> _commandHistory = new Stack<ICommand>();

    public void ExecuteOperation(ICommand command)
    {
        command.Execute();
        _commandHistory.Push(command);
    }

    public void CancelLastOperation()
    {
        if (_commandHistory.Count > 0)
        {
            ICommand lastCommand = _commandHistory.Pop();
            lastCommand.Undo();
        }
        else
        {
            Console.WriteLine("[Адміністратор]: Немає операцій для скасування.");
        }
    }
}