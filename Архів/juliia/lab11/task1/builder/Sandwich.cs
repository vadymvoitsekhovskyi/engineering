namespace builder;

internal class Sandwich : ISandwich
{
    public List<string> Ingredients { get; } = new List<string>();

    public void AddIngredient(string ingredient)
    {
        Ingredients.Add(ingredient);
    }

    public override string ToString()
    {
        return string.Join(", ", Ingredients);
    }
}