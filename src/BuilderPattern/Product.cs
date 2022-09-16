namespace BuilderPattern;

public class Product
{
    private List<string> _dish = new List<string>();

    public void Add(string input)
    {
        _dish.Add(input);
    }

    public string[] Display()
    {
        return _dish.ToArray();
    }
}
