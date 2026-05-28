namespace composite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            Module mainCourse = new Module("Програмна інженерія: Повний курс");
            
            Module basisModule = new Module("Основи програмування");
            Module patternsModule = new Module("Патерни проектування");
            
            Lesson lesson1 = new Lesson("Вступ до C#");
            Lesson lesson2 = new Lesson("Змінні та типи даних");
            Lesson lesson3 = new Lesson("Патерн Adapter");
            Lesson lesson4 = new Lesson("Патерн Composite");
            
            basisModule.Add(lesson1);
            basisModule.Add(lesson2);
            
            patternsModule.Add(lesson3);
            patternsModule.Add(lesson4);
            
            mainCourse.Add(basisModule);
            mainCourse.Add(patternsModule);
            
            mainCourse.Add(new Lesson("Фінальний іспит"));
            
            Console.WriteLine("Структура онлайн-курсу");
            mainCourse.Display(1);
            
            Console.WriteLine("\nПісля видалення 'Патерн Adapter'");
            patternsModule.Remove(lesson3);
            mainCourse.Display(1);
        }
    }
}