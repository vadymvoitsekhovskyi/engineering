namespace factory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CourseFactory factory = new UniversityCourseFactory();

            try
            {
                Course csharpCourse = factory.CreateCourse("online");
                csharpCourse.Title = "Основи програмування на C#";
                csharpCourse.EnrollStudent("Олександр");
                csharpCourse.ConductLesson();
                
                Course mathCourse = factory.CreateCourse("offline");
                mathCourse.Title = "Вища математика";
                mathCourse.EnrollStudent("Марія");
                mathCourse.ConductLesson();
                
                Course unknownCourse = factory.CreateCourse("hybrid");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Помилка створення курсу: {ex.Message}");
            }
        }
    }
}