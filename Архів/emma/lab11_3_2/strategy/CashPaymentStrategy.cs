namespace strategy;

public class CashPaymentStrategy : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"[Готівка] Оплачено {amount} грн. Офіціант отримав чайові готівкою!");
    }
}