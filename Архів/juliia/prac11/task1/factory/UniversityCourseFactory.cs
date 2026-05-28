namespace factory;

public class UniversityCourseFactory : CourseFactory
{
    public override Course CreateCourse(string courseType)
    {
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