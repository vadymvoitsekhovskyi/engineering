namespace strategy;

public class CardPaymentStrategy : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"[Картка] Оплачено {amount} грн через термінал. Транзакція успішна.");
    }
}