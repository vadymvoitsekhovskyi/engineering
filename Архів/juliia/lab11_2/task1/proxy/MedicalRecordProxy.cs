namespace proxy;

public class MedicalRecordProxy : IMedicalRecord
{
    private RealMedicalRecord _realRecord;
    private string _userRole;

    public MedicalRecordProxy(RealMedicalRecord realRecord, string userRole)
    {
        _realRecord = realRecord;
        _userRole = userRole;
    }

    public void Display()
    {
        Console.WriteLine($"Access attempt with role: {_userRole}");

        if (_userRole.Equals("Doctor", StringComparison.OrdinalIgnoreCase)) // порівняти рядки без урахування регістру
        {
            _realRecord.Display();
        }
        else if (_userRole.Equals("Administrator", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Limited Medical Record");
            Console.WriteLine($"Patient Name: {_realRecord.GetPatientName()}");
            Console.WriteLine($"Age: {_realRecord.GetAge()}");
        }
        else
        {
            Console.WriteLine("Access denied: unknown role.");
        }
    }
}