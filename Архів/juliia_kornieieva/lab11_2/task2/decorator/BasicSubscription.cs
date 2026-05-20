namespace decorator;

public class BasicSubscription : Subscription
{
    public override string GetDescription()
    {
        return "Базова підписка";
    }

    public override double GetCost()
    {
        return 8.99;
    }
}