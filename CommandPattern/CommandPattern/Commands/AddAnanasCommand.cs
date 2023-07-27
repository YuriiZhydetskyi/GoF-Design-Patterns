using Builder;

namespace CommandPattern.Commands;

internal class AddAnanasCommand<TFood> : AddFoodCommand<TFood>, ICommand where TFood : Food, new()
{
    public AddAnanasCommand(CustomFoodBuilder<TFood> builder) : base(builder)
    {
    }

    public override void Execute()
    {
        _builder.AddAnanas();
        _builder.PrintCurrentIngredients();
    }

    public override void Undo()
    {
        _builder.RemoveAnanas();
        _builder.PrintCurrentIngredients();
    }
}
