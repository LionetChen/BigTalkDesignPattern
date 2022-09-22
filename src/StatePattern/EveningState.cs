using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern;
public class EveningState : WorkerState
{
    public override string WorkOneHour(DayOfWorker context)
    {
        context.TimeGoesByOneHour();
        string activity = $"Work until {context.MilitaryTime} hours. Productivity: low";

        if (context.MilitaryTime == 2200)
        {
            context.SetState(new RestState());
        }

        return activity;
    }
}
