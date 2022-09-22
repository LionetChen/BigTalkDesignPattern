using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern;
public class WorkerState
{
    public virtual string WorkOneHour(DayOfWorker context)
    {
        throw new InvalidOperationException($"Cannot work at {context.MilitaryTime} hours.");
    }

    public virtual string TakeNap(DayOfWorker context)
    {
        throw new InvalidOperationException($"Cannot take a nap at {context.MilitaryTime} hours.");
    }
    public virtual string EatLunch(DayOfWorker context)
    {
        throw new InvalidOperationException($"Cannot eat lunch at {context.MilitaryTime} hours.");
    }

}
