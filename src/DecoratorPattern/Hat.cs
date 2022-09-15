namespace DecoratorPattern;

public class Hat : DecoratorBase
{
    public override IEnumerable<string> Wear()
    {
        return base.Wear().Append(nameof(Hat));
    }
}
