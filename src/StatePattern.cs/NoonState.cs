using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern;
public class NoonState : WorkerState
{
    public override string EatLunch(DayOfWorker context)
    {
        context.TimeGoesByOneHour();
        string activity = $"Eat lunch until {context.MilitaryTime} hours";
        if (context.MilitaryTime == 1400)
        {
            context.SetState(new AfternoonState());
        }

        return activity;
    }

    public override string TakeNap(DayOfWorker context)
    {
        context.TimeGoesByOneHour();
        string activity = $"Take a nap until {context.MilitaryTime} hours";
        if (context.MilitaryTime == 1400)
        {
            context.SetState(new AfternoonState());
        }

        return activity;
    }
}
