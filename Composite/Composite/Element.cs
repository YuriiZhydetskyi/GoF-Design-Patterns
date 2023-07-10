namespace Composite;

internal abstract class Element
{
    protected int _value;
    public Element(int value) => _value = value;
    public abstract void Increment();
    public abstract void Decrement();

    public virtual void Print(string shift) => Console.WriteLine(shift + _value.ToString());
}
