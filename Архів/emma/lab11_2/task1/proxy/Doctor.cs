namespace proxy;

public class Doctor
{
    private string _name;

    public Doctor(string name)
    {
        _name = name;
    }

    public void ViewRecord(IMedicalRecord medicalRecord)
    {
        medicalRecord.Display();
        Console.WriteLine($"Doctor {_name} is viewing the record.");
        Console.WriteLine();
    }
}