namespace Builder;

internal class Pizza : Food
{
    public Pizza()
    {
        Ingredients = new List<string>();
    }
    
    public override void Introduce()
    {
        Console.WriteLine();
        Console.WriteLine("I'm your pizza with " + string.Join(", ", Ingredients));
    }
}
