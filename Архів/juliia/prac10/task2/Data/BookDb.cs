namespace task2
{
	public class BookDb : IBookRepository
	{
		private readonly List<Book> _books = new List<Book>();

		public void AddBook(Book book)
		{
			_books.Add(book);
		}

		public List<Book> GetAll()
		{
			return new List<Book>(_books);
		}
	}
}