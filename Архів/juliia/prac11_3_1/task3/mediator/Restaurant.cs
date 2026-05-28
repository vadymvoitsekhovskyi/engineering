namespace mediator;

public class Restaurant : HotelDepartment
{
    public void DeliverFood()
    {
        Console.WriteLine("Ресторан - їжу доставлено в номер гостя.");
        _mediator.Notify(this, "FoodDelivered");
    }
}