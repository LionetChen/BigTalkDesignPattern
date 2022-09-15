namespace DecoratorPattern;

public class Shoes : DecoratorBase
{
    public override IEnumerable<string> Wear()
    {
        return base.Wear().Append(nameof(Shoes));
    }
}
