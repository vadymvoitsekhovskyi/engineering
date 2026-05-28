namespace decorator;

public class OfflineDecorator : SubscriptionDecorator
{
    public OfflineDecorator(Subscription subscription) : base(subscription)
    {
        
    }

    public override string GetDescription()
    {
        return WrappedSubscription.GetDescription() + ", Offline";
    }

    public override double GetCost()
    {
        return WrappedSubscription.GetCost() + 3.00;
    }
}