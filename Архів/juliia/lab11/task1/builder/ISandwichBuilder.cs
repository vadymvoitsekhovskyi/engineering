namespace builder;

public interface ISandwichBuilder
{
    ISandwichBuilder AddBread();
    ISandwichBuilder AddMeat();
    ISandwichBuilder AddVegetables();
    ISandwichBuilder AddSauce();
    ISandwich GetSandwich();
}