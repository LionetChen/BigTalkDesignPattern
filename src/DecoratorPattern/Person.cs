namespace DecoratorPattern;

public class Person : DecorableSubject
{
    public override List<string> Wear()
    {
        return new List<string>() { };
    }
}
