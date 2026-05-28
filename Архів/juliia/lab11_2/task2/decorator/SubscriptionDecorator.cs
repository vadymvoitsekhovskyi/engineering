namespace decorator;

public abstract class SubscriptionDecorator : Subscription
{
    protected Subscription WrappedSubscription;

    protected SubscriptionDecorator(Subscription subscription)
    {
        WrappedSubscription = subscription;
    }
}