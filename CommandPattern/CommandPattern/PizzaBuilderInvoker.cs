using CommandPattern.Commands;

namespace CommandPattern;

internal class PizzaBuilderInvoker
{
    private Stack<ICommand> doneCommands = new();
    private Stack<ICommand> undoneCommands = new();


    public void Execute(ICommand command)
    {
        command.Execute();
        doneCommands.Push(command);
        undoneCommands = new Stack<ICommand>();
    }

    public void Undo()
    {
        if (doneCommands.Count == 0)
        {
            return;
        }

        var command = doneCommands.Pop();
        command.Undo();
        undoneCommands.Push(command);
    }

    public void Redo()
    {
        if (undoneCommands.Count == 0)
        {
            return;
        }

        var command = undoneCommands.Pop();
        command.Execute();
        doneCommands.Push(command);
    }
}
