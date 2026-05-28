namespace strategy;

public class RestaurantOrder
{
    private IPaymentStrategy _paymentStrategy;
    private decimal _totalAmount;

    public RestaurantOrder(decimal totalAmount)
    {
        _totalAmount = totalAmount;
    }
    
    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void Checkout()
    {
        if (_paymentStrategy == null)
        {
            Console.WriteLine("Помилка! Будь ласка, оберіть спосіб оплати перед розрахунком!");
            return;
        }
        
        _paymentStrategy.Pay(_totalAmount);
    }
}