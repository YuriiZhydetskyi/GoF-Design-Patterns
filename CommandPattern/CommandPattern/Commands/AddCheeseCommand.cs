using Builder;

namespace CommandPattern.Commands;

internal class AddCheeseCommand<TFood> : AddFoodCommand<TFood>, ICommand where TFood : Food, new()
{
    public AddCheeseCommand(CustomFoodBuilder<TFood> builder) : base(builder)
    {
    }

    public override void Execute()
    {
        _builder.AddCheese();
        _builder.PrintCurrentIngredients();
    }

    public override void Undo()
    {
        _builder.RemoveCheese();
        _builder.PrintCurrentIngredients();
    }
}
