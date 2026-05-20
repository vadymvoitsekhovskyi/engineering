using System.Text;

namespace task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            IBookRepository storage = new BookDb();
            ILibraryService service = new LibraryService(storage);

            UserInterface userInterface = new UserInterface(service);
            userInterface.Start();
        }
    }
}