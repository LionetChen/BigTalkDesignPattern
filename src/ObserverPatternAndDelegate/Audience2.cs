namespace ObserverPatternAndDelegate
{
    public class Audience2 : AudienceBase
    {
        public override void Watches(string showName)
        {
            State = $"{nameof(Audience2)} watches {showName}";
        }
    }
}