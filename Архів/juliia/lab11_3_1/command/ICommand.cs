namespace command;

public interface ICommand
{
    void Execute();
    void Undo();
}