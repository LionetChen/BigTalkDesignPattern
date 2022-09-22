namespace StatePattern;
public class DayOfWorker
{
    public DayOfWorker()
    {
        MilitaryTime = 800;
        _state = new MorningState();
    }

    private WorkerState _state;
    public int MilitaryTime { get; private set; }
    public string CurrentState => _state.GetType().Name;

    public void TimeGoesByOneHour()
    {
        MilitaryTime += 100;
    }

    public void SetState(WorkerState newState)
    {
        _state = newState;
    }

    public string Work()
    {
        return _state.WorkOneHour(this);
    }

    public string Nap()
    {
        return _state.TakeNap(this);
    }

    public string Lunch()
    {
        return _state.EatLunch(this);
    }
}
