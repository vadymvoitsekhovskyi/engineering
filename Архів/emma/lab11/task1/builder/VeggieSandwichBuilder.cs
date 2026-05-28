namespace builder;

public class VeggieSandwichBuilder : ISandwichBuilder
{
    private Sandwich _sandwich = new Sandwich();

    public ISandwichBuilder AddBread()
    {
        _sandwich.AddIngredient("Цільнозерновий хліб");
        return this;
    }

    public ISandwichBuilder AddMeat()
    {
        return this;
    }

    public ISandwichBuilder AddVegetables()
    {
        _sandwich.AddIngredient("Листя салату");
        _sandwich.AddIngredient("Томат");
        _sandwich.AddIngredient("Огірок");
        _sandwich.AddIngredient("Болгарський перець");
        return this;
    }

    public ISandwichBuilder AddSauce()
    {
        _sandwich.AddIngredient("Соус песто");
        return this;
    }

    public ISandwich GetSandwich()
    {
        Sandwich result = _sandwich;
        _sandwich = new Sandwich();
        return result;
    }
}