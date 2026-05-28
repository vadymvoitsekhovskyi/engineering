namespace chain_of_responsibility;

public class Director : Approver
{
    public override void ProcessRequest(PurchaseRequest request)
    {
        if (request.Amount <= 5000)
        {
            Console.WriteLine($"Директор погодив закупівлю '{request.Purpose}' на суму ${request.Amount}");
        }
        else
        {
            nextApprover.ProcessRequest(request);
        }
    }
}