using Builder;

namespace CommandPattern.Commands;

internal class AddBackonCommand<TFood> : AddFoodCommand<TFood>, ICommand where TFood : Food, new()
{
    public AddBackonCommand(CustomFoodBuilder<TFood> builder) : base(builder)
    {
    }

    public override void Execute()
    {
        _builder.AddBackon();
        _builder.PrintCurrentIngredients();
    }

    public override void Undo()
    {
        _builder.RemoveBackon();
        _builder.PrintCurrentIngredients();
    }
}
