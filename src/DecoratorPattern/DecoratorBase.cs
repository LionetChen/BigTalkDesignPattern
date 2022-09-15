namespace DecoratorPattern;

public class DecoratorBase : DecorableSubject
{
    private DecorableSubject? _subject;

    public void Decorate(DecorableSubject subject)
    {
        this._subject = subject;
    }

    public override IEnumerable<string> Wear()
    {
        if (_subject == null)
            throw new InvalidOperationException("Decorate any subject before showing!");
        return _subject.Wear();
    }
}
