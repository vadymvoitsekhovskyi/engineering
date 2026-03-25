namespace factory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Система запису студентів на курси (Factory Method) ===\n");
            
            CourseFactory factory = new UniversityCourseFactory();

            try
            {
                // Створюємо онлайн курс через фабрику
                Course csharpCourse = factory.CreateCourse("online");
                csharpCourse.Title = "Основи програмування на C#";
                csharpCourse.EnrollStudent("Олександр");
                csharpCourse.ConductLesson();

                // Створюємо офлайн курс через фабрику
                Course mathCourse = factory.CreateCourse("offline");
                mathCourse.Title = "Вища математика";
                mathCourse.EnrollStudent("Марія");
                mathCourse.ConductLesson();

                // Спроба створити невідомий курс (для перевірки обробки помилок)
                 Course unknownCourse = factory.CreateCourse("hybrid");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Помилка створення курсу: {ex.Message}");
            }

            Console.WriteLine("Натисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}