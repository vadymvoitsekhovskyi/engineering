namespace chain_of_responsibility;

public class CEO : Approver
{
    public override void ProcessRequest(PurchaseRequest request)
    {
        if (request.Amount > 5000)
        {
            Console.WriteLine($"Генеральний директор погодив закупівлю '{request.Purpose}' на суму ${request.Amount}");
        }
    }
}