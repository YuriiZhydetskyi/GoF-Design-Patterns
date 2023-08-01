namespace Builder;

internal abstract class Food
{
    public abstract void Introduce();
    public List<string> Ingredients { get; set; }
}
