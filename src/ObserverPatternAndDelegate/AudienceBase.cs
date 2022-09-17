namespace ObserverPatternAndDelegate;
public abstract class AudienceBase
{
    public string State { get; protected set; } = string.Empty;

    public abstract void Watches(string showName);
}
