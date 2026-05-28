namespace chain_of_responsibility;

public class Manager : Approver
{
    public override void ProcessRequest(PurchaseRequest request)
    {
        if (request.Amount <= 1000)
        {
            Console.WriteLine($"Менеджер погодив закупівлю '{request.Purpose}' на суму ${request.Amount}");
        }
        else
        {
            nextApprover.ProcessRequest(request);
        }
    }
}