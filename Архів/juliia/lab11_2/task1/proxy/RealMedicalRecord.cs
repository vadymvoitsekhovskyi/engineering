namespace proxy;

public class RealMedicalRecord : IMedicalRecord
{
    private string _patientName;
    private int _age;
    private string _diagnosis;
    private string _treatment;
    private string _medicalHistory;

    public RealMedicalRecord(string patientName, int age, string diagnosis, string treatment, string medicalHistory)
    {
        _patientName = patientName;
        _age = age;
        _diagnosis = diagnosis;
        _treatment = treatment;
        _medicalHistory = medicalHistory;
    }

    public void Display()
    {
        Console.WriteLine("Full Medical Record");
        Console.WriteLine($"Patient Name: {_patientName}");
        Console.WriteLine($"Age: {_age}");
        Console.WriteLine($"Diagnosis: {_diagnosis}");
        Console.WriteLine($"Treatment: {_treatment}");
        Console.WriteLine($"Medical History: {_medicalHistory}");
    }

    public string GetPatientName()
    {
        return _patientName;
    }

    public int GetAge()
    {
        return _age;
    }
}