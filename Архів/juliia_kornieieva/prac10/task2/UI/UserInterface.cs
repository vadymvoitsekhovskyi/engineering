namespace task2
{
    public class UserInterface
    {
        private readonly ILibraryService _service;

        public UserInterface(ILibraryService service)
        {
            _service = service;
        }

        public void Start()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("БІБЛІОТЕКА");
                Console.WriteLine("1. Додати книгу.");
                Console.WriteLine("2. Переглянути всі книги.");
                Console.WriteLine("3. Вихід.");
                Console.Write("Ваш вибір: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddBookUI();
                        break;
                    case "2":
                        ShowBooksUI();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Невірний вибір. Натисніть Enter.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private void AddBookUI()
        {
            Console.WriteLine("\nНова книга");
            Console.Write("Введіть назву: ");
            string title = Console.ReadLine();

            Console.Write("Введіть автора: ");
            string author = Console.ReadLine();

            try
            {
                _service.AddBook(title, author);
                Console.WriteLine("Книгу успішно додано! Натисніть Enter.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }

            Console.ReadLine();
        }

        private void ShowBooksUI()
        {
            Console.WriteLine("\nСписок книг");
            var books = _service.GetLibraryContent();

            if (books.Count == 0)
            {
                Console.WriteLine("Бібліотека порожня.");
            }
            else
            {
                foreach (var book in books)
                {
                    Console.WriteLine(book);
                }
            }

            Console.WriteLine("\nНатисніть Enter, щоб продовжити.");
            Console.ReadLine();
        }
    }
}