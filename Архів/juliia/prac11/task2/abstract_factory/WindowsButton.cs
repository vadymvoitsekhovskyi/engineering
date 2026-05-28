namespace abstract_factory;

public class WindowsButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Малюємо Windows кнопку у стилі Fluent Design.");
    }

    public void OnClick()
    {
        Console.WriteLine("Обробка натискання Windows кнопки.");
    }
}