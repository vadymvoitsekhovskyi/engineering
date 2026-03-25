namespace factory;

public class UniversityCourseFactory : CourseFactory
{
    public override Course CreateCourse(string courseType)
    {
        // Логіка створення потрібного об'єкту на основі рядкового параметра
        switch (courseType.ToLower().Trim())
        {
            case "online":
                return new OnlineCourse();
            case "offline":
                return new OfflineCourse();
            default:
                // Якщо тип невідомий, кидаємо виняток
                throw new ArgumentException($"Невідомий тип курсу: {courseType}");
        }
    }
}