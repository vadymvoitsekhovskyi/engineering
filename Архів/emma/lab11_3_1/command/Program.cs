namespace command
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Система автоматизації роботи університету\n");
            
            UniversityDatabase database = new UniversityDatabase();
            UniversityAdministrator admin = new UniversityAdministrator();
            
            ICommand enrollIvan = new EnrollStudentCommand(database, "Іван Іваненко", "ФІОТ");
            ICommand enrollMaria = new EnrollStudentCommand(database, "Марія Петренко", "ФПМ");
            ICommand scheduleMath = new ScheduleExamCommand(database, "Вища математика", DateTime.Now.AddDays(14));
            
            Console.WriteLine("Виконання операцій");
            admin.ExecuteOperation(enrollIvan);
            admin.ExecuteOperation(enrollMaria);
            admin.ExecuteOperation(scheduleMath);

            Console.WriteLine("\nСталася помилка, скасовуємо останні дії");
            
            admin.CancelLastOperation();
            admin.CancelLastOperation();
        }
    }
}