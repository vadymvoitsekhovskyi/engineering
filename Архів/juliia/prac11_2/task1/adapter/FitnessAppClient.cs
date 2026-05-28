namespace adapter;

public class FitnessAppClient
{
    private IDistanceTracker _tracker;
    
    public FitnessAppClient(IDistanceTracker tracker)
    {
        _tracker = tracker;
    }
    
    public void ShowDistance()
    {
        Console.WriteLine($"Пройдена відстань: {_tracker.GetDistanceKm():F2} км");
    }
}