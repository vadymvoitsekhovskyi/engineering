namespace abstract_factory;

public interface IUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}