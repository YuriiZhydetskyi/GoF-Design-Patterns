namespace Builder;

internal class PizzaBuilder : CustomFoodBuilder<Pizza>
{
    public override PizzaBuilder AddAnanas()
    {
        _food.Ingredients.Add("Ananas");
        return this;
    }

    public override PizzaBuilder AddBackon()
    {
        _food.Ingredients.Add("Backon");
        return this;
    }

    public override PizzaBuilder AddCheese()
    {
        _food.Ingredients.Add("Cheese");
        return this;
    }

    public override PizzaBuilder AddFish()
    {
        _food.Ingredients.Add("Fish");
        return this;
    }

    public override PizzaBuilder AddMushrooms()
    {
        _food.Ingredients.Add("Mushrooms");
        return this;
    }
}
