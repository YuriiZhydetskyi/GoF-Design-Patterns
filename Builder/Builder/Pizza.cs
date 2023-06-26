namespace Builder;

internal class Pizza : IFood
{
    public Pizza()
    {
        Ingredients = new List<string>();
    }
    public List<string> Ingredients { get; set; }
    public void Introduce()
    {
        Console.WriteLine();
        Console.WriteLine("I'm your pizza with " + string.Join(", ", Ingredients));
    }
}
