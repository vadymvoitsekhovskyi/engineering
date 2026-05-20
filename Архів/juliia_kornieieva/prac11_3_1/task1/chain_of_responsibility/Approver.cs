namespace chain_of_responsibility;

public abstract class Approver
{
    protected Approver nextApprover;
    
    public void SetNext(Approver approver)
    {
        nextApprover = approver;
    }
    
    public abstract void ProcessRequest(PurchaseRequest request);
}