namespace ChainOfResponsibilityPattern;
public abstract class SuperiorBase
{
    public SuperiorBase Superior { get; private set; } = null!;
    public abstract string Review(RequestBase request);
    public SuperiorBase SetNext(SuperiorBase superior)
    {
        return Superior = superior;
    }
}
