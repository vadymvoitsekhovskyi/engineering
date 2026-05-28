namespace decorator;

public class HdDecorator : SubscriptionDecorator
{
    public HdDecorator(Subscription subscription) : base(subscription)
    {
        
    }

    public override string GetDescription()
    {
        return WrappedSubscription.GetDescription() + ", HD";
    }

    public override double GetCost()
    {
        return WrappedSubscription.GetCost() + 2.00;
    }
}