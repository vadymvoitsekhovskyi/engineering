namespace chain_of_responsibility;

public class PurchaseRequest
{
    public string Purpose { get; set; }
    public double Amount { get; set; }

    public PurchaseRequest(string purpose, double amount)
    {
        Purpose = purpose;
        Amount = amount;
    }
}