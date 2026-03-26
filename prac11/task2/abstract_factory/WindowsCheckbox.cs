namespace abstract_factory;

public class WindowsCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Малюємо Windows чекбокс.");
    }

    public void OnClick()
    {
        Console.WriteLine("Зміна стану Windows чекбокса.");
    }
}