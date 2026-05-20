namespace strategy;

public class CryptoPaymentStrategy : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"[Крипта] Оплачено {amount} грн у Bitcoin. Сучасно!");
    }
}