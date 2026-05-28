namespace proxy;

public class Administrator
{
    private string _name;

    public Administrator(string name)
    {
        _name = name;
    }

    public void ViewRecord(IMedicalRecord medicalRecord)
    {
        medicalRecord.Display();
        Console.WriteLine($"Administrator {_name} is viewing the record.");
        Console.WriteLine();
    }
}