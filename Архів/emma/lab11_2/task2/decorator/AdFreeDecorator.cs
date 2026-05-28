namespace decorator;

public class AdFreeDecorator : SubscriptionDecorator
{
    public AdFreeDecorator(Subscription subscription) : base(subscription)
    {
        
    }

    public override string GetDescription()
    {
        return WrappedSubscription.GetDescription() + ", Ad-Free";
    }

    public override double GetCost()
    {
        return WrappedSubscription.GetCost() + 3.00;
    }
}