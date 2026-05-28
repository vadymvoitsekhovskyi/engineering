namespace abstract_factory;

public class Application
{
    private readonly IButton _button;
    private readonly ICheckbox _checkbox;
    
    public Application(IUIFactory factory)
    {
        _button = factory.CreateButton();
        _checkbox = factory.CreateCheckbox();
    }

    public void RenderUI()
    {
        Console.WriteLine("Рендеринг інтерфейсу");
        _button.Render();
        _checkbox.Render();
    }

    public void SimulateUserInteraction()
    {
        Console.WriteLine("\nВзаємодія з користувачем");
        _button.OnClick();
        _checkbox.OnClick();
    }
}