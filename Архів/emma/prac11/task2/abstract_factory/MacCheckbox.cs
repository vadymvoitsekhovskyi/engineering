namespace abstract_factory;

public class MacCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Малюємо Mac чекбокс.");
    }

    public void OnClick()
    {
        Console.WriteLine("Зміна стану Mac чекбокса.");
    }
}