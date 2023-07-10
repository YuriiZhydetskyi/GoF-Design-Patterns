namespace Composite;

internal class Node : Element
{
    private IEnumerable<Element> _children = new List<Element>();
    public Node(int value) : base(value)
    {
    }

    public override void Decrement()
    {
        --_value;
        foreach (var child in _children)
        {
            child.Decrement();
        }
    }

    public override void Increment()
    {
        ++_value;
        foreach (var child in _children)
        {
            child.Increment();
        }
    }

    public void Add(Element element)
    {
        _children = _children.Append(element);
    }

    public void Remove(Element element)
    {
        _children = _children.Where(e => e != element);
    }

    public override void Print(string shift)
    {
        base.Print(shift);
        foreach (var child in _children)
        {
            child.Print(shift + "--");
        }
    }
}
