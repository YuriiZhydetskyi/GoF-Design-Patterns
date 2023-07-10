namespace Composite;

internal class Leaf : Element
{
    public Leaf(int value) : base(value)
    {
    }

    public override void Decrement()
    {
        --_value;
    }

    public override void Increment()
    {
        ++_value;
    }
}
