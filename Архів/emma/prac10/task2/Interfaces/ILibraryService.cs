namespace task2
{
	public interface ILibraryService
	{
		void AddBook(string title, string author);
		List<Book> GetLibraryContent();
	}
}