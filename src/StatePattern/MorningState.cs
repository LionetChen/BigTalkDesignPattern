using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern;
public class MorningState : WorkerState
{
    public override string WorkOneHour(DayOfWorker context)
    {
        context.TimeGoesByOneHour();
        string activity = $"Work until {context.MilitaryTime} hours. Productivity: high";        
        
        if (context.MilitaryTime == 1200)
        {
            context.SetState(new NoonState());
        }

        return activity;
    }
}
