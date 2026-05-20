namespace visitor;

public interface ILibraryItem
{
    void Accept(IVisitor visitor);
}