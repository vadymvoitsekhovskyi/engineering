namespace proxy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RealMedicalRecord realRecord = new RealMedicalRecord("Petro Ivanenko", 52, "Hypertension", "Medication therapy",
                "Chronic condition");

            Doctor doctor = new Doctor("John");
            Administrator administrator = new Administrator("Ivan Petrenko");

            IMedicalRecord doctorProxy = new MedicalRecordProxy(realRecord, "Doctor");
            IMedicalRecord adminProxy = new MedicalRecordProxy(realRecord, "Administrator");

            doctor.ViewRecord(doctorProxy);
            administrator.ViewRecord(adminProxy);
        }
    }
}