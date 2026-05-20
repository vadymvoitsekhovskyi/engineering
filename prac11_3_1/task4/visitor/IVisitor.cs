namespace visitor;

public interface IVisitor
{
    void Visit(Book book);
    void Visit(Magazine magazine);
}