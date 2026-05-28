namespace adapter;

public class DistanceAdapter : IDistanceTracker
{
    private ExternalTracker _externalTracker;
    private const double MilesToKmFactor = 1.609344;
    
    public DistanceAdapter(ExternalTracker tracker)
    {
        _externalTracker = tracker;
    }
    
    public double GetDistanceKm()
    {
        double miles = _externalTracker.GetDistanceMiles();
        return miles * MilesToKmFactor;
    }
}