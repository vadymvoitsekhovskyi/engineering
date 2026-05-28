namespace mediator;

public class HotelDepartment
{
    protected IMediator _mediator;

    public HotelDepartment(IMediator mediator = null)
    {
        _mediator = mediator;
    }

    public void SetMediator(IMediator mediator)
    {
        _mediator = mediator;
    }
}