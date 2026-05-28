namespace factory;

public abstract class CourseFactory
{
    public abstract Course CreateCourse(string courseType);
}