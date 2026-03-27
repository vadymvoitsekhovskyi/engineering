namespace builder;

public class MeatLoversBuilder : ISandwichBuilder
{
    private Sandwich _sandwich = new Sandwich();

    public ISandwichBuilder AddBread()
    {
        _sandwich.AddIngredient("Пшеничний хліб");
        return this;
    }

    public ISandwichBuilder AddMeat()
    {
        _sandwich.AddIngredient("Куряча грудка");
        _sandwich.AddIngredient("Бекон");
        return this;
    }

    public ISandwichBuilder AddVegetables()
    {
        _sandwich.AddIngredient("Листя салату");
        _sandwich.AddIngredient("Томат");
        return this;
    }

    public ISandwichBuilder AddSauce()
    {
        _sandwich.AddIngredient("Барбекю соус");
        return this;
    }

    public ISandwich GetSandwich()
    {
        Sandwich result = _sandwich;
        _sandwich = new Sandwich();
        return result;
    }
}