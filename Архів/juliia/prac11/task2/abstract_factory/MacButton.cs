namespace abstract_factory;

public class MacButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Малюємо Mac кнопку у стилі Aqua.");
    }

    public void OnClick()
    {
        Console.WriteLine("Обробка натискання Mac кнопки.");
    }
}