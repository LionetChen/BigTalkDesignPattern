namespace DecoratorPattern;

public abstract class DecorableSubject
{
    public abstract IEnumerable<string> Wear();

    public string Show()
    {
        var wearings = Wear();
        return "This person is " + 
            (wearings.Count() == 0 ? "naked." : "wearing " + string.Join(", ", Wear()));
    }
}
