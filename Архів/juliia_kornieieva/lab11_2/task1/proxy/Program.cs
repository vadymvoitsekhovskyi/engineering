namespace proxy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RealMedicalRecord realRecord = new RealMedicalRecord("Ivan", 50, "Hypertension", "Medication therapy",
                "Chronic condition");

            Doctor doctor = new Doctor("Petro");
            Administrator administrator = new Administrator("Valeriy");

            IMedicalRecord doctorProxy = new MedicalRecordProxy(realRecord, "Doctor");
            IMedicalRecord adminProxy = new MedicalRecordProxy(realRecord, "Administrator");

            doctor.ViewRecord(doctorProxy);
            administrator.ViewRecord(adminProxy);
        }
    }
}