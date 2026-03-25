namespace factory;

public class UniversityCourseFactory : CourseFactory
{
    public override Course CreateCourse(string courseType)
    {
        // створення потрібного об'єкту на основі рядкового параметра
        switch (courseType.ToLower().Trim())
        {
            case "online":
                return new OnlineCourse();
            case "offline":
                return new OfflineCourse();
            default:
                throw new ArgumentException($"Невідомий тип курсу: {courseType}");
        }
    }
}