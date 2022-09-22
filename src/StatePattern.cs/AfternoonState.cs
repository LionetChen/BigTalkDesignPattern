using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern;
public class AfternoonState : WorkerState
{
    public override string WorkOneHour(DayOfWorker context)
    {
        context.TimeGoesByOneHour();
        string activity = $"Work until {context.MilitaryTime} hours. Productivity: moderate";

        if (context.MilitaryTime == 1800)
        {
            context.SetState(new EveningState());
        }

        return activity;
    }
}
