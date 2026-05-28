namespace builder;

public class Director
{
    private readonly ISandwichBuilder _builder;

    public Director(ISandwichBuilder builder)
    {
        _builder = builder;
    }

    public void BuildSandwich()
    {
        _builder.AddBread()
            .AddMeat()
            .AddVegetables()
            .AddSauce();
    }
}