using Builder;

namespace CommandPattern.Commands;

internal abstract class AddFoodCommand<TFood> : ICommand where TFood : Food, new()
{
    protected readonly CustomFoodBuilder<TFood> _builder;

    public AddFoodCommand(CustomFoodBuilder<TFood> builder)
    {
        _builder = builder;
    }

    public abstract void Execute();
    public abstract void Undo();
}
