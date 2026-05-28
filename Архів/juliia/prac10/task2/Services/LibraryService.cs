namespace task2
{
    public class LibraryService : ILibraryService
    {
        private readonly IBookRepository _bookRepository;
        private int _nextId = 1;    

        public LibraryService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void AddBook(string title, string author)
        {

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author))
            {
                throw new ArgumentException("Назва книги та автор не можуть бути порожніми.");
            }

            var book = new Book
            {
                Id = _nextId++,
                Title = title,
                Author = author
            };

            _bookRepository.AddBook(book);
        }

        public List<Book> GetLibraryContent()
        {
            return _bookRepository.GetAll();
        }
    }
}