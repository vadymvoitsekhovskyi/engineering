namespace task2
{
    public interface IBookRepository
    {
        void AddBook(Book book);
        List<Book> GetAll();
    }
}