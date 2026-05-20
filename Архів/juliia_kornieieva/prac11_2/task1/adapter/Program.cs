namespace adapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            double milesWalked = 5.0;
            ExternalTracker externalTracker = new ExternalTracker(milesWalked);
            Console.WriteLine($"Сторонній трекер показує: {externalTracker.GetDistanceMiles()} миль");
            
            IDistanceTracker adapter = new DistanceAdapter(externalTracker);
            FitnessAppClient appClient = new FitnessAppClient(adapter);
            appClient.ShowDistance();
        }
    }
}