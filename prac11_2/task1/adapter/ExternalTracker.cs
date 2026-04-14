namespace adapter;

public class ExternalTracker
{
    private double _distanceInMiles;
    
    public ExternalTracker(double distance)
    {
        _distanceInMiles = distance;
    }

    public double GetDistanceMiles()
    {
        return _distanceInMiles;
    }
}